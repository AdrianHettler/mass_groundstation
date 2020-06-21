using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace mass_groundstation
{
    public partial class MainForm : Form
    {
        public static NetworkStream tcp_stream;
        public static TcpClient tcp_client;
        private bool tcp_connected = false;

        UdpClient udp_client;
        IPEndPoint udp_endpoint;

        BackgroundWorker worker;

        public void init_charts()
        {
            this.chart_temperature.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            this.chart_temperature.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            this.chart_temperature.ChartAreas[0].AxisX.Minimum = 0;
            this.chart_temperature.ChartAreas[0].AxisX.Maximum = 0.417;
            this.chart_temperature.ChartAreas[0].AxisY.Minimum = -70;
            this.chart_temperature.ChartAreas[0].AxisY.Maximum = 40;
            this.chart_temperature.ChartAreas[0].AxisY.Interval = 5;
            this.chart_temperature.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            this.chart_temperature.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            this.chart_temperature.ChartAreas[0].AxisX.Title = "Time in [h]";
            this.chart_temperature.ChartAreas[0].AxisY.Title = "Temperature in [°C]";
            this.chart_temperature.Series[0].Color = Color.Red;
            this.chart_temperature.Series[1].Color = Color.Blue;

            this.chart_pressure.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            this.chart_pressure.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            this.chart_pressure.ChartAreas[0].AxisX.Minimum = 0;
            this.chart_pressure.ChartAreas[0].AxisX.Maximum = 0.417;
            this.chart_pressure.ChartAreas[0].AxisY.Minimum = 0;
            this.chart_pressure.ChartAreas[0].AxisY.Maximum = 1200;
            this.chart_pressure.ChartAreas[0].AxisY.Interval = 100;
            this.chart_pressure.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            this.chart_pressure.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            this.chart_pressure.ChartAreas[0].AxisX.Title = "Time in [h]";
            this.chart_pressure.ChartAreas[0].AxisY.Title = "Pressure in [hPa]";
            
        }
        public MainForm()
        {
            DateTime init_time = DateTime.Now;
            DateTime empty_dt = new DateTime();

            InitializeComponent();
            init_charts();

            TimeSpan time = DateTime.Now - init_time; 
            
            this.chart_temperature.Series["Temperature_Inside"].Points.AddXY(empty_dt + time, 20);
            this.chart_temperature.Series["Temperature_Inside"].Points.AddXY(empty_dt.AddHours(1) + time, 30);

            this.chart_temperature.Series["Temperature_Outside"].Points.AddXY(empty_dt + time, 30);
            this.chart_temperature.Series["Temperature_Outside"].Points.AddXY(empty_dt.AddHours(1) + time, 10);

            this.chart_pressure.Series["Pressure"].Points.AddXY(empty_dt + time, 20);
            this.chart_pressure.Series["Pressure"].Points.AddXY(empty_dt.AddHours(1) + time, 30);


            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true; //set to true to fire the progress-changed event
            worker.DoWork += refresh_connections;

            Thread thdUDPServer = new Thread(new ThreadStart(udp_server_thread));
            thdUDPServer.Start();

        }

        public void udp_server_thread()
        {
            udp_client = new UdpClient((int)numericUpDown_UDP_PORT.Value);
            udp_endpoint = new IPEndPoint(IPAddress.Parse(textBox_EXP_IP.Text), 0);

            while (true)
            {
                try
                {
                    Byte[] receiveBytes = udp_client.Receive(ref udp_endpoint);
                    //string returnData = Encoding.ASCII.GetString(receiveBytes);


                    //    OutputTextBox.Invoke((MethodInvoker)delegate
                    //{
                    //    OutputTextBox_add_output_message(returnData.ToString());
                    //});

                }

                catch (Exception except)
                {
                    OutputTextBox.Invoke((MethodInvoker)delegate
                    {
                        OutputTextBox_add_output_message(except.Message);
                    });
                }
            }
        }


        private void refresh_connections(object sender, DoWorkEventArgs e)
        {
            PingReply reply = Helper.ping_ip(textBox_EXP_IP.Text);
            if (reply.Status == IPStatus.Success)
            {
                label_PING_TIME.Invoke((MethodInvoker)delegate
                {
                    label_PING_TIME.Text = reply.RoundtripTime.ToString() + " ms";
                    label_PING_TIME.ForeColor = reply.RoundtripTime < 50 ? Color.Green : Color.Orange;
                });
            }
            else
            {
                label_PING_TIME.Invoke((MethodInvoker)delegate
                {
                    label_PING_TIME.Text = "NOT CONNECTED";
                    label_PING_TIME.ForeColor = Color.Red;
                });
            }

            if (!tcp_connected)
            {
                try
                {
                    bool tcp_init = Helper.init_tcp_client(textBox_EXP_IP.Text, (int)numericUpDown_TCP_PORT.Value);
                    if (tcp_init)
                    {
                        tcp_stream = Helper.get_tcp_netstream();
                        tcp_client = Helper.get_tcp_client();
                        tcp_connected = Helper.send_initial_tcp_payload();

                        if(tcp_connected)
                            OutputTextBox_add_output_message("TCP INIT SUCCESS", false);
                        else
                            OutputTextBox_add_output_message("TCP INIT ERROR - IP/PORT found, initial Write/Read Failed", false);                          
                    }
                    else
                    {
                        OutputTextBox_add_output_message("TCP INIT ERROR - IP/PORT not available (NO CONNECTION)", false);
                    }
                }
                catch (Exception except)
                {
                    OutputTextBox_add_output_message("TCP INIT ERROR - Exception thrown: " + except.Message, false);
                }
            }

            if (tcp_connected)
            {
                byte[] message_ping_payload = { 0x2, 0x2 };

                try
                {
                    if (tcp_stream.CanWrite)
                    {
                        tcp_stream.Write(message_ping_payload, 0, message_ping_payload.Length);

                        if (tcp_stream.CanRead)
                        {
                            byte[] message_ping_payload_receive = new byte[tcp_client.ReceiveBufferSize];
                            int bytesRead = tcp_stream.Read(message_ping_payload_receive, 0, tcp_client.ReceiveBufferSize);

                            if (message_ping_payload_receive[0] == (byte)3)
                                Helper.change_label(label_TCP_STATUS_OUTPUT, "CONNECTED", Color.Green, false);
                            else
                                Helper.change_label(label_TCP_STATUS_OUTPUT, "NOT CONNECTED", Color.Red, false);                       
                        }
                    }
                }
                catch (Exception except)
                {
                    Helper.close_tcp_client();
                    tcp_connected = false;
                    OutputTextBox_add_output_message("TCP READ/WRITE ERROR - Exception: " + except.Message,false);
                    Helper.change_label(label_TCP_STATUS_OUTPUT, "NOT CONNECTED", Color.Red, false);
                }
            }
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {
            // always display latest active output ->       
            OutputTextBox.SelectionStart = OutputTextBox.Text.Length;   // set the current caret position to the end       
            OutputTextBox.ScrollToCaret();   // scroll it automatically     
        }


        public void OutputTextBox_add_output_message(string text, bool GUI_thread = true, bool add_timestamp = true, bool log = true)
        {
            string output_text = DateTime.Now.ToString("HH:mm:ss  -  ") + text; // add time to output

            if (log)
            {
                Helper.write_log(output_text);
            }

            if(GUI_thread)
            {
                OutputTextBox.AppendText(output_text);  // add text to OutputTextBox
                OutputTextBox.AppendText(Environment.NewLine); // new line
            }
            else
            {
                OutputTextBox.Invoke((MethodInvoker)delegate
                {
                    OutputTextBox.AppendText(output_text);  // add text to OutputTextBox
                    OutputTextBox.AppendText(Environment.NewLine); // new line
                });
            }
        }

        private void clear_log_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Log.txt"))
            {
                File.Delete(@"C:\Log.txt");
            }
        }

        private void button_refresh_EXP_IP_Click(object sender, EventArgs e)
        {
            textBox_GS_IP.Text = Helper.get_local_ip();
        }

        private void checkBox_lock_IP_config_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_lock_IP_config.Checked)
            {
                textBox_GS_IP.ReadOnly = true;
                textBox_EXP_IP.ReadOnly = true;
                numericUpDown_UDP_PORT.ReadOnly = true;
                numericUpDown_TCP_PORT.ReadOnly = true;
            }
            else
            {
                textBox_GS_IP.ReadOnly = false;
                textBox_EXP_IP.ReadOnly = false;
                numericUpDown_UDP_PORT.ReadOnly = false;
                numericUpDown_TCP_PORT.ReadOnly = false;
            }
        }

        private void button_single_PING_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                label_connection_last_refresh_output.Text = DateTime.Now.ToString("HH:mm:ss");
                worker.RunWorkerAsync();
            }
        }

        private void numericUpDown_ping_refresh_ValueChanged(object sender, EventArgs e)
        {
            timer_ping_refresh.Interval = (int)numericUpDown_ping_refresh.Value * 1000; // Interval in ms
        }

        private void timer_ping_refresh_Tick(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                label_connection_last_refresh_output.Text = DateTime.Now.ToString("HH:mm:ss");
                worker.RunWorkerAsync();
            }
        }

        private void button_CAM1_START_Click(object sender, EventArgs e)
        {
            label_CAM1_STATUS.Text = "RECORDING";
            label_CAM1_STATUS.ForeColor = Color.Green;
        }

        private void button_CAM1_STOP_Click(object sender, EventArgs e)
        {
            label_CAM1_STATUS.Text = "NOT RECORDING";
            label_CAM1_STATUS.ForeColor = Color.Red;
        }



        private void checkBox_CAM1_LOCK_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_CAM1_LOCK.Checked)
            {
                button_CAM1_START.Enabled = false;
                button_CAM1_STOP.Enabled = false;
            }
            else
            {
                button_CAM1_START.Enabled = true;
                button_CAM1_STOP.Enabled = true;
            }
        }

        private void button_CAM2_START_Click(object sender, EventArgs e)
        {
            label_CAM2_STATUS.Text = "RECORDING";
            label_CAM2_STATUS.ForeColor = Color.Green;
        }

        private void button_CAM2_STOP_Click(object sender, EventArgs e)
        {
            label_CAM2_STATUS.Text = "NOT RECORDING";
            label_CAM2_STATUS.ForeColor = Color.Red;
        }



        private void checkBox_CAM2_LOCK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CAM2_LOCK.Checked)
            {
                button_CAM2_START.Enabled = false;
                button_CAM2_STOP.Enabled = false;
            }
            else
            {
                button_CAM2_START.Enabled = true;
                button_CAM2_STOP.Enabled = true;
            }
        }

        private void checkBox_HDRM_Inside_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HDRM_Inside_Lock.Checked)
                button_HDRM_Inside_Release.Enabled = false;
            else
                button_HDRM_Inside_Release.Enabled = true;

        }

        private void checkBox_HDRM_Outside_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HDRM_Outside_Lock.Checked)           
                button_HDRM_Outside_Release.Enabled = false;         
            else            
                button_HDRM_Outside_Release.Enabled = true;           
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_pneu_manual_override_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pneu_manual_override.Checked)
            {
                button_valve_pressure_inside.Enabled = true;
                button_valve_pressure_outside.Enabled = true;
                button_valve_ambient_inside.Enabled = true;
                button_valve_ambient_outside.Enabled = true;
            }
            else
            {
                button_valve_pressure_inside.Enabled = false;
                button_valve_pressure_outside.Enabled = false;
                button_valve_ambient_inside.Enabled = false;
                button_valve_ambient_outside.Enabled = false;
            }
        }

        private void checkBox_Inflation_Inside_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Inflation_Inside_Lock.Checked)
            {
                button_Inflation_Inside_Start.Enabled = false;
                button_Inflation_Inside_Stop.Enabled = false;
            }
            else
            {
                button_Inflation_Inside_Start.Enabled = true;
                button_Inflation_Inside_Stop.Enabled = true;
            }
             
        }

        private void checkBox_Inflation_Outside_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Inflation_Outside_Lock.Checked)
            {
                button_Inflation_Outside_Start.Enabled = false;
                button_Inflation_Outside_Stop.Enabled = false;
            }    
            else
            { 
                button_Inflation_Outside_Start.Enabled = true;
                button_Inflation_Outside_Stop.Enabled = true;
            }
        }

        private void checkBox_UV_ST2_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UV_ST2_Lock.Checked)
            {
                button_UV_ST2_ON.Enabled = false;
                button_UV_ST2_OFF.Enabled = false;
            }
            else
            {
                button_UV_ST2_ON.Enabled = true;
                button_UV_ST2_OFF.Enabled = true;
            }
        }

        private void checkBox_UV_ST1_Lock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UV_ST1_Lock.Checked)
            {
                button_UV_ST1_ON.Enabled = false;
                button_UV_ST1_OFF.Enabled = false;
            }
            else
            {
                button_UV_ST1_ON.Enabled = true;
                button_UV_ST1_OFF.Enabled = true;
            }
        }
    }
}




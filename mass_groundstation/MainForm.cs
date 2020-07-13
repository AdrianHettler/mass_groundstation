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

    public struct tcp_command
    {
        public int message_id;
        public byte[] data;
        public int data_size;
    }



    public partial class MainForm : Form
    {
        public static NetworkStream tcp_stream;
        public static TcpClient tcp_client;
        private bool tcp_connected = false;

        UdpClient udp_client;
        IPEndPoint udp_endpoint;

        List<tcp_command> tcp_command_list = new List<tcp_command>();


        bool valve_1 = false, valve_2 = false, valve_3 = false, valve_4 = false;
        DateTime init_time = DateTime.Now;
        DateTime empty_dt = new DateTime();

        public void init_charts()
        {
            this.chart_temperature.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            this.chart_temperature.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            this.chart_temperature.ChartAreas[0].AxisX.Minimum = 0;
            this.chart_temperature.ChartAreas[0].AxisX.Maximum = 0.0417;
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
           

            InitializeComponent();
            init_charts();

           
            //this.chart_temperature.Series["Temperature_Outside"].Points.AddXY(empty_dt + time, 30);
           // this.chart_temperature.Series["Temperature_Outside"].Points.AddXY(empty_dt.AddHours(1) + time, 10);
           // this.chart_pressure.Series["Pressure"].Points.AddXY(empty_dt + time, 20);
           // this.chart_pressure.Series["Pressure"].Points.AddXY(empty_dt.AddHours(1) + time, 30);


            Thread thdUDPServer = new Thread(new ThreadStart(udp_server_thread));
            thdUDPServer.Start();

            Thread thd_tcp = new Thread(new ThreadStart(tcp_thread));
            thd_tcp.Start();

        }

        public void tcp_thread()
        {
            while (true)
            {
                Thread.Sleep(20);

                try
                {
                    if (!tcp_connected) // INIT TCP CLIENT
                    {
                        try
                        {
                            bool tcp_init = Helper.init_tcp_client(textBox_EXP_IP.Text, (int)numericUpDown_TCP_PORT.Value);
                            if (tcp_init)
                            {
                                tcp_stream = Helper.get_tcp_netstream();
                                tcp_client = Helper.get_tcp_client();
                                tcp_connected = Helper.send_initial_tcp_payload();

                                if (tcp_connected)
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

                    if (tcp_connected && tcp_command_list.Count > 0)
                    {
                        bool found = false;

                        try
                        {
                            switch (tcp_command_list[0].message_id)
                            {
                                case message_ids.PING:
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
                                    found = true;
                                    break;

                                case message_ids.TCP_PING:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message_tcp_ping_payload = { message_ids.TCP_PING };

                                        tcp_stream.Write(message_tcp_ping_payload, 0, message_tcp_ping_payload.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_ping_payload_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_ping_payload_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_ping_payload_receive[0] == message_ids.TCP_PONG)
                                                Helper.change_label(label_TCP_STATUS_OUTPUT, "CONNECTED", Color.Green, false);
                                            else
                                                Helper.change_label(label_TCP_STATUS_OUTPUT, "NOT CONNECTED", Color.Red, false);
                                        }
                                    }
                                    found = true;
                                    break;

                                case message_ids.EXP_RELEASE_STRUCTURES:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message = { message_ids.EXP_RELEASE_STRUCTURES, tcp_command_list[0].data[0] };

                                        tcp_stream.Write(message, 0, message.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_receive[0] == message_ids.OK)
                                                OutputTextBox_add_output_message("Exp. Release Structure Command SUCCESS", false);
                                            else
                                                OutputTextBox_add_output_message("Exp. Release Structure Command FAIL", false);
                                        }
                                    }
                                    found = true;
                                    break;

                                case message_ids.EXP_UV_ON:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message = { message_ids.EXP_UV_ON, tcp_command_list[0].data[0] };

                                        tcp_stream.Write(message, 0, message.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_receive[0] == message_ids.OK)
                                                OutputTextBox_add_output_message("Exp. UV ON SUCCESS", false);
                                            else
                                                OutputTextBox_add_output_message("Exp. UV ON FAIL", false);
                                        }
                                    }
                                    found = true;
                                    break;

                                case message_ids.EXP_UV_OFF:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message = { message_ids.EXP_UV_OFF, tcp_command_list[0].data[0] };

                                        tcp_stream.Write(message, 0, message.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_receive[0] == message_ids.OK)
                                                OutputTextBox_add_output_message("Exp. UV OFF SUCCESS", false);
                                            else
                                                OutputTextBox_add_output_message("Exp. UV OFF FAIL", false);
                                        }
                                    }
                                    found = true;
                                    break;

                                case message_ids.EXP_VALVES_MANUAL_ON:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message = { message_ids.EXP_VALVES_MANUAL_ON, tcp_command_list[0].data[0] };

                                        tcp_stream.Write(message, 0, message.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_receive[0] == message_ids.OK)
                                                OutputTextBox_add_output_message("Exp. VALVES_MANUAL_ON SUCCESS", false);
                                            else
                                                OutputTextBox_add_output_message("Exp. VALVES_MANUAL_ON FAIL", false);
                                        }
                                    }
                                    found = true;
                                    break;

                                case message_ids.EXP_VALVES_MANUAL_OFF:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message = { message_ids.EXP_VALVES_MANUAL_OFF, tcp_command_list[0].data[0] };

                                        tcp_stream.Write(message, 0, message.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_receive[0] == message_ids.OK)
                                                OutputTextBox_add_output_message("Exp. VALVES_MANUAL_OFF SUCCESS", false);
                                            else
                                                OutputTextBox_add_output_message("Exp. VALVES_MANUAL_OFF FAIL", false);
                                        }
                                    }
                                    found = true;
                                    break;

                                case message_ids.EXP_START_INFLATION:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message = { message_ids.EXP_START_INFLATION, tcp_command_list[0].data[0] };

                                        tcp_stream.Write(message, 0, message.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_receive[0] == message_ids.OK)
                                                OutputTextBox_add_output_message("Exp. EXP_START_INFLATION SUCCESS", false);
                                            else
                                                OutputTextBox_add_output_message("Exp. EXP_START_INFLATION FAIL", false);
                                        }
                                    }
                                    found = true;
                                    break;

                                case message_ids.EXP_STOP_INFLATION:
                                    if (tcp_stream.CanWrite)
                                    {
                                        byte[] message = { message_ids.EXP_STOP_INFLATION, tcp_command_list[0].data[0] };

                                        tcp_stream.Write(message, 0, message.Length);

                                        if (tcp_stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[tcp_client.ReceiveBufferSize];
                                            int bytesRead = tcp_stream.Read(message_receive, 0, tcp_client.ReceiveBufferSize);

                                            if (message_receive[0] == message_ids.OK)
                                                OutputTextBox_add_output_message("Exp. EXP_STOP_INFLATION SUCCESS", false);
                                            else
                                                OutputTextBox_add_output_message("Exp. EXP_STOP_INFLATION FAIL", false);
                                        }
                                    }
                                    found = true;
                                    break;
                            }

                            if (found)
                            {
                                tcp_command_list.RemoveAt(0); // remove the first entry
                            }
                        }
                        catch (Exception except)
                        {
                            Helper.close_tcp_client();
                            tcp_connected = false;
                            OutputTextBox_add_output_message("TCP READ/WRITE ERROR - Exception: " + except.Message, false);
                            Helper.change_label(label_TCP_STATUS_OUTPUT, "NOT CONNECTED", Color.Red, false);
                        }
                    }
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

        public void udp_server_thread()
        {
            udp_client = new UdpClient((int)numericUpDown_UDP_PORT.Value);
            udp_endpoint = new IPEndPoint(IPAddress.Parse(textBox_EXP_IP.Text), 0);

            while (true)
            {
                try
                {
                    Byte[] received_bytes = udp_client.Receive(ref udp_endpoint);
                    //string returnData = Encoding.ASCII.GetString(receiveBytes);

                    switch (received_bytes[0])
                    {
                        case message_ids.DATA_ENVIROMENTAL:
                            float ambient_temp_inside = BitConverter.ToSingle(received_bytes, 1);

                            TimeSpan time = DateTime.Now - init_time;                          

                            float ambient_temp_outside = BitConverter.ToSingle(received_bytes, 5);
                            float ambient_pressure = BitConverter.ToSingle(received_bytes, 9);

                            OutputTextBox.Invoke((MethodInvoker)delegate
                            {
                                textBox_current_ambient_temperature_inside.Text = ambient_temp_inside.ToString() + " °C";
                                textBox_current_ambient_temperature_outside.Text = ambient_temp_outside.ToString() + " °C";
                                textBox_current_ambient_pressure.Text = ambient_pressure.ToString() + " hPa";
                                this.chart_temperature.Series["Temperature_Inside"].Points.AddXY(empty_dt + time, ambient_temp_inside);
                                this.chart_pressure.Series["Pressure"].Points.AddXY(empty_dt + time, ambient_pressure);
                            });

                            break;

                        case message_ids.DATA_POWER:
                            float voltage_bexus = BitConverter.ToSingle(received_bytes, 1);
                            float voltage_extra = BitConverter.ToSingle(received_bytes, 5);
                            float current_bexus = BitConverter.ToSingle(received_bytes, 9);
                            float current_extra = BitConverter.ToSingle(received_bytes, 13);
                            float power_bexus = voltage_bexus * current_bexus;
                            float power_extra = voltage_extra * current_extra;

                            OutputTextBox.Invoke((MethodInvoker)delegate
                            {
                                textBox_BEXUS_Voltage.Text = voltage_bexus.ToString() + " V";
                                textBox_EXTRA_Voltage.Text = voltage_extra.ToString() + " V";
                                textBox_BEXUS_Current.Text = current_bexus.ToString() + " A";
                                textBox_EXTRA_Current.Text = current_extra.ToString() + " A";
                                textBox_BEXUS_Power.Text = power_bexus.ToString() + " W";
                                textBox_EXTRA_Power.Text = power_extra.ToString() + " W";

                            });

                            break;

                        case message_ids.DATA_PNEUMATICS:

                            float pressure_tank = BitConverter.ToSingle(received_bytes, 1);
                            float pressure_outside_structures = BitConverter.ToSingle(received_bytes, 5);
                            float pressure_inside_structures = BitConverter.ToSingle(received_bytes, 9);

                            OutputTextBox.Invoke((MethodInvoker)delegate
                            {
                                textBox_PNEU_Tank.Text = pressure_tank.ToString() + " hPa";
                                textBox_PNEU_Outside_Structures.Text = pressure_outside_structures.ToString() + " hPa";
                                textBox_PNEU_Inside_Structures.Text = pressure_inside_structures.ToString() + " hPa";
                            });

                            break;
                    }
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

            if (GUI_thread)
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

            tcp_command command_ip_ping = new tcp_command();
            command_ip_ping.message_id = message_ids.PING;
            tcp_command_list.Add(command_ip_ping);

            tcp_command command_tcp_ping = new tcp_command();
            command_tcp_ping.message_id = message_ids.TCP_PING;
            tcp_command_list.Add(command_tcp_ping);

            label_connection_last_refresh_output.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void numericUpDown_ping_refresh_ValueChanged(object sender, EventArgs e)
        {
            timer_ping_refresh.Interval = (int)numericUpDown_ping_refresh.Value * 1000; // Interval in ms
        }

        private void timer_ping_refresh_Tick(object sender, EventArgs e)
        {
            tcp_command command_ip_ping = new tcp_command();
            command_ip_ping.message_id = message_ids.PING;
            tcp_command_list.Add(command_ip_ping);

            tcp_command command_tcp_ping = new tcp_command();
            command_tcp_ping.message_id = message_ids.TCP_PING;
            tcp_command_list.Add(command_tcp_ping);

            label_connection_last_refresh_output.Text = DateTime.Now.ToString("HH:mm:ss");
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
            if (checkBox_CAM1_LOCK.Checked)
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

        private void button_HDRM_Inside_Release_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_RELEASE_STRUCTURES;
            command.data = new byte[1];
            command.data[0] = 1;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_HDRM_Outside_Release_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_RELEASE_STRUCTURES;
            command.data = new byte[1];
            command.data[0] = 2;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_UV_ST1_ON_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_UV_ON;
            command.data = new byte[1];
            command.data[0] = 1;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_valve_pressure_outside_Click(object sender, EventArgs e)
        {
            valve_3 = !valve_3;
            tcp_command command = new tcp_command();

            if (valve_3)
                command.message_id = message_ids.EXP_VALVES_MANUAL_ON;
            else
                command.message_id = message_ids.EXP_VALVES_MANUAL_OFF;

            command.data = new byte[1];
            command.data[0] = 3;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_valve_pressure_inside_Click(object sender, EventArgs e)
        {
            valve_1 = !valve_1;
            tcp_command command = new tcp_command();

            if (valve_1)
                command.message_id = message_ids.EXP_VALVES_MANUAL_ON;
            else
                command.message_id = message_ids.EXP_VALVES_MANUAL_OFF;

            command.data = new byte[1];
            command.data[0] = 1;
            command.data_size = 1;
            tcp_command_list.Add(command);         
        }

        private void button_valve_ambient_inside_Click(object sender, EventArgs e)
        {
            valve_2 = !valve_2;
            tcp_command command = new tcp_command();

            if (valve_2)
                command.message_id = message_ids.EXP_VALVES_MANUAL_ON;
            else
                command.message_id = message_ids.EXP_VALVES_MANUAL_OFF;

            command.data = new byte[1];
            command.data[0] = 2;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_valve_ambient_outside_Click(object sender, EventArgs e)
        {
            valve_4 = !valve_4;
            tcp_command command = new tcp_command();

            if (valve_4)
                command.message_id = message_ids.EXP_VALVES_MANUAL_ON;
            else
                command.message_id = message_ids.EXP_VALVES_MANUAL_OFF;

            command.data = new byte[1];
            command.data[0] = 4;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_Inflation_Inside_Start_Click(object sender, EventArgs e)
        {

            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_START_INFLATION;
            command.data = new byte[1];
            command.data[0] = 1;
            command.data_size = 1;
            tcp_command_list.Add(command);       
        }

        private void button_Inflation_Inside_Stop_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_STOP_INFLATION;
            command.data = new byte[1];
            command.data[0] = 1;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_Inflation_Outside_Start_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_START_INFLATION;
            command.data = new byte[1];
            command.data[0] = 2;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_Inflation_Outside_Stop_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_STOP_INFLATION;
            command.data = new byte[1];
            command.data[0] = 2;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_UV_ST1_OFF_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_UV_OFF;
            command.data = new byte[1];
            command.data[0] = 1;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_UV_ST2_ON_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_UV_ON;
            command.data = new byte[1];
            command.data[0] = 2;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

        private void button_UV_ST2_OFF_Click(object sender, EventArgs e)
        {
            tcp_command command = new tcp_command();
            command.message_id = message_ids.EXP_UV_OFF;
            command.data = new byte[1];
            command.data[0] = 2;
            command.data_size = 1;
            tcp_command_list.Add(command);
        }

    
    }
}




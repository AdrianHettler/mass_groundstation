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

        BackgroundWorker worker;
        public MainForm()
        {
            InitializeComponent();

            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true; //set to true to fire the progress-changed event
            worker.DoWork += refresh_connections;
        }

        private void refresh_connections(object sender, DoWorkEventArgs e)
        {
            PingReply reply = Helper.ping_ip(textBox_EXP_IP.Text);
            if (reply.Status == IPStatus.Success)
            {
                label_PING_TIME.Invoke((MethodInvoker)delegate
                {
                    label_PING_TIME.Text = reply.RoundtripTime.ToString() + " ms";
                    label_PING_TIME.ForeColor = reply.RoundtripTime < 50 ? Color.Green : Color.Yellow; ;
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

            if(tcp_connected)
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
                            {
                                label_TCP_STATUS_OUTPUT.Invoke((MethodInvoker)delegate
                                {
                                    label_TCP_STATUS_OUTPUT.Text = "CONNECTED";
                                    label_TCP_STATUS_OUTPUT.ForeColor = Color.Green;
                                });
                            }
                            else
                            {
                                label_TCP_STATUS_OUTPUT.Invoke((MethodInvoker)delegate
                                {
                                    label_TCP_STATUS_OUTPUT.Text = "NOT CONNECTED";
                                    label_TCP_STATUS_OUTPUT.ForeColor = Color.Red;
                                });
                            }
                        }
                    }
                }
                catch (Exception except)
                {
                    Helper.close_tcp_client();
                    tcp_connected = false;

                    OutputTextBox.Invoke((MethodInvoker)delegate
                    {
                        OutputTextBox_add_output_message(except.Message);
                    });

                    label_TCP_STATUS_OUTPUT.Invoke((MethodInvoker)delegate
                    {
                        label_TCP_STATUS_OUTPUT.Text = "NOT CONNECTED";
                        label_TCP_STATUS_OUTPUT.ForeColor = Color.Red;
                    });

                }
            }
            else
            {
                try
                {
                    bool tcp_init = Helper.init_tcp_client(textBox_EXP_IP.Text, (int)numericUpDown_TCP_PORT.Value);
                    if(tcp_init)
                    {
                        tcp_stream = Helper.get_tcp_netstream();
                        tcp_client = Helper.get_tcp_client();
                        tcp_connected = Helper.send_initial_tcp_payload();
                    }
                    else
                    {
                        OutputTextBox.Invoke((MethodInvoker)delegate
                        {
                            OutputTextBox_add_output_message("TCP Initiation failed");
                        });
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

        public static void write_log(string log)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Log.txt", true))
            {
                sw.WriteLine(log);
            }
        }

        public void OutputTextBox_add_output_message(string text, bool add_timestamp = true, bool log = true)
        {
            string output_text = DateTime.Now.ToString("hh:mm:ss  -  ") + text; // add time to output

            if (log)
            {
                write_log(output_text);
            }

            OutputTextBox.AppendText(output_text);  // add text to OutputTextBox
            OutputTextBox.AppendText(Environment.NewLine); // new line
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputTextBox_add_output_message("hi this is a test", true, enable_logging.Checked);
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
            if(checkBox_lock_IP_config.Checked)
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
                label_connection_last_refresh_output.Text = DateTime.Now.ToString("hh:mm:ss");
                worker.RunWorkerAsync();
            }
        }

        private void numericUpDown_ping_refresh_ValueChanged(object sender, EventArgs e)
        {        
            timer_ping_refresh.Interval = (int)numericUpDown_ping_refresh.Value * 1000; // Interval in ms
        }

        private void timer_ping_refresh_Tick(object sender, EventArgs e)
        {
           if(!worker.IsBusy)
            {
                label_connection_last_refresh_output.Text = DateTime.Now.ToString("hh:mm:ss");
                worker.RunWorkerAsync();
            }              
        }
    }
}




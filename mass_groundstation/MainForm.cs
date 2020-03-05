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
        public delegate void testDelegate();
        bool ip_connected = false;

     

        public MainForm()
        {
            InitializeComponent();

            Thread t = new Thread(new ThreadStart(tcp_thread));
            t.Start();

            //BeginWork();

        }

        public struct message
        {
            public message(ushort Length, byte Message_id)
            {
                length = Length;
                message_id = Message_id;
            }

            public ushort length;
            public byte message_id;
        }

        byte[] getBytes(message str)
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;

        }

        message fromBytes(byte[] arr)
        {
            message str = new message();

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (message)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);

            return str;
        }

        private void tcp_thread()
        {
            NetworkStream tcp_stream = Helper.init_tcp_client(textBox_EXP_IP.Text, (int)numericUpDown_TCP_PORT.Value);
            TcpClient tcp_client = Helper.get_tcp_client();

            while (true)
            {
                message test_msg;
                test_msg.length = 2;
                test_msg.message_id = 1;


                byte[] bytesToSend = getBytes(test_msg);

                tcp_stream.Write(bytesToSend, 0, bytesToSend.Length);

                //---read back the text---
                byte[] bytesToRead = new byte[tcp_client.ReceiveBufferSize];


                int bytesRead = tcp_stream.Read(bytesToRead, 0, tcp_client.ReceiveBufferSize);
               // OutputTextBox_add_output_message("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
                // Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
               
                Task.Delay(500);
            }
        }


        private async void BeginWork()
        {
            NetworkStream tcp_stream = Helper.init_tcp_client(textBox_EXP_IP.Text, (int)numericUpDown_TCP_PORT.Value);
            TcpClient tcp_client = Helper.get_tcp_client();       
        }

        private async void thread()
        {
            if (OutputTextBox.InvokeRequired)
            {
                OutputTextBox.BeginInvoke(new testDelegate(thread));
            }
            else
            {
                OutputTextBox_add_output_message("TST");
            }

            Thread.Sleep(10);
        }

        private async void tcp_client()
        {
            string textToSend = DateTime.Now.ToString();

            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new TcpClient(textBox_EXP_IP.Text, (int)numericUpDown_TCP_PORT.Value);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            Console.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            Console.ReadLine();
            client.Close();
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
            PingReply reply = Helper.ping_ip(textBox_EXP_IP.Text);

            if (reply.Status == IPStatus.Success)
            {
                label_PING_TIME.Text = reply.RoundtripTime.ToString() + " ms";
                label_PING_TIME.ForeColor = reply.RoundtripTime < 50 ? Color.Green : Color.Yellow; ;
                ip_connected = true;
            }
            else
            {
                label_PING_TIME.Text = "NOT CONNECTED";
                label_PING_TIME.ForeColor = Color.Red;
                ip_connected = false;
            }
        }


    }
}




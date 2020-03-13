using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;


namespace mass_groundstation
{
    public static class Helper
    {
        

        enum tcp_message_id : byte
        {
            empty,
            status_ok,
            ping,
            pong,
            error = 254
        }


        public static byte[] message_ping = { (byte)tcp_message_id.ping, 2 };


        private static TcpClient tcp_client;
        private static NetworkStream tcp_stream;

        public static string get_local_ip()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address.ToString();
            }
        }

        public static PingReply ping_ip(string ip)
        {
            Ping p = new Ping();
            PingReply r;

            r = p.Send(ip);

            return r;


            //if (r.Status == IPStatus.Success)
            //{
            //   // lblpingstatus.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "] successful - " + r.Buffer.Length.ToString() + " bytes in " + r.RoundtripTime.ToString() + " ms." + "\n";
            //}
        }

        public static bool init_tcp_client(string exp_ip,int tcp_port)
        {
            tcp_client = new TcpClient();
            var result = tcp_client.BeginConnect(exp_ip, (int)tcp_port, null, null);
            var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));

            if (!success)
            {
                return false;
            }

            tcp_stream = tcp_client.GetStream();
            tcp_stream.ReadTimeout = 1000;
            tcp_stream.WriteTimeout = 1000;

            return true;
        }

        public static TcpClient get_tcp_client()
        {
            return tcp_client;
        }

        public static NetworkStream get_tcp_netstream()
        {
            return tcp_stream;
        }

        public static void close_tcp_client()
        {
            tcp_client.Close();
        }

        public static bool send_initial_tcp_payload()
        {
            byte[] message_ping_payload = { 0xFF, 0xFF, 0xFF, 0xFF };

            if (tcp_stream.CanWrite)
            {
                tcp_stream.Write(message_ping_payload, 0, message_ping_payload.Length);

                if (tcp_stream.CanRead)
                {
                    byte[] message_ping_payload_receive = new byte[tcp_client.ReceiveBufferSize];
                    tcp_stream.Read(message_ping_payload_receive, 0, tcp_client.ReceiveBufferSize);
                    return true;
                }
            }
            return false;
        }

        public static void change_label(Label lab, string text, Color col, bool GUI_thread = true)
        {
            if (GUI_thread)
            {
                lab.Text = text;
                lab.ForeColor = col;
            }
            else
            {
                lab.Invoke((MethodInvoker)delegate
                {
                    lab.Text = text;
                    lab.ForeColor = col;
                });
            }
        }

        public static void write_log(string log, string log_path = @"C:\Log.txt")
        {
            using (StreamWriter sw = new StreamWriter(log_path, true))
            {
                sw.WriteLine(log);
            }
        }
    }
}

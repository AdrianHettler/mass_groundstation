using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace mass_groundstation
{
    public static class Helper
    {
        public static TcpClient tcp_client;

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

        public static NetworkStream init_tcp_client(string exp_ip,int tcp_port)
        {
             tcp_client = new TcpClient(exp_ip, (int)tcp_port);
             return tcp_client.GetStream();
        }

        public static TcpClient get_tcp_client()
        {
            return tcp_client;
        }
            
        public static void close_tcp_client()
        {
            tcp_client.Close();
        }



    }
}

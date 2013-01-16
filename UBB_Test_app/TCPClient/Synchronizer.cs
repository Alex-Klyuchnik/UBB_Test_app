using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace UBB_Test_app.TCPClient
{
    internal class Synchronizer
    {
        public Synchronizer()
        {
            fillIPlist();
            synchronizer = new Thread(this.Run);
        }

        private Thread synchronizer;
        private int port = 7777;
        private List<IPAddress> ipList;



        private void fillIPlist()
        {
            //TODO: fill IP address list from the settings container
        }

        private bool check(IPAddress ip)
        {
            StreamReader reader;
            StreamWriter writer;
            using (TcpClient tcpClient = new TcpClient(new IPEndPoint(ip, port)))
            {
                reader = new StreamReader(tcpClient.GetStream());
                writer = new StreamWriter(tcpClient.GetStream());
                writer.WriteLine("#99");
                writer.Flush();
                if ((reader.ReadLine() != "Success") || !tcpClient.Connected)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private IPAddress GetIPAddress()
        {
            foreach (IPAddress ip in ipList)
            {
                if (check(ip))
                {
                    return ip;
                }
            }
            //return null;
            return default(IPAddress);
        }

        public void Run()
        {
            IPAddress addr = GetIPAddress();
            if (addr != null)
            {
                //TODO: function to check is local database empty
                //TODO: call a function to send local data to server
            }
            
            Thread.Sleep(30000);
        }

        public void StartChecker()
        {
            synchronizer.Start();
        }
        public void StopChecker()
        {
            synchronizer.Abort();
        }

        public IPAddress IpAddress
        {
            get { return GetIPAddress(); }
        }
    }
}
    
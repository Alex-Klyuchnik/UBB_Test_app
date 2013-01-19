using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UBB_Test_app.Properties;

namespace UBB_Test_app.TCPClient
{
    internal class Synchronizer
    {
        public Synchronizer()
        {
            FillIPList();
            synchronizer = new Thread(this.Run);
        }

        private Thread synchronizer;
        private int port = 9050;
        private List<IPAddress> ipList = new List<IPAddress>();



        private void FillIPList()
        {
            foreach (string ipAddress in ConnectionEstablisherClient.ipList)  //TODO Move to settings
            {
                ipList.Add(IPAddress.Parse(ipAddress));
            }
        }

        private bool Check(IPAddress ip)
        {
            StreamReader reader;
            StreamWriter writer;
            Parser parser = new Parser();
            try
            {
                using (TcpClient tcpClient = new TcpClient(ip.ToString(), port))
                {
                    reader = new StreamReader(tcpClient.GetStream());
                    writer = new StreamWriter(tcpClient.GetStream());
                    writer.WriteLine(parser.TestConnectionEncode());
                    writer.Flush();
                    if ((reader.ReadLine() != Resources.Success) || !tcpClient.Connected)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch(SocketException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public IPAddress GetIPAddress()
        {
            foreach (IPAddress ip in ipList)
            {
                if (Check(ip))
                {
                    return ip;
                }
            }
            return null;
            //return default(IPAddress);
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
    
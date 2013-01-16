using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            StreamReader rdr;
            StreamWriter wrtr;
            using (TcpClient cl = new TcpClient(new IPEndPoint(ip, port)))
            {
                rdr = new StreamReader(cl.GetStream());
                wrtr = new StreamWriter(cl.GetStream());
                wrtr.WriteLine("#99");
                wrtr.Flush();
                if ((rdr.ReadLine() != "Success") || !cl.Connected)
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
    
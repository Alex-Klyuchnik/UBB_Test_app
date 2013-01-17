using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ServerServiceApp.TCP_Server
{
    public class ConnectionEstablisher
    {
        public void Listen() //TODO Rewrite with networkStream. Read - Act - Write.
        {
            string msg= "";
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipEndPoint);
            newsock.Listen(10);
            Socket client = newsock.Accept();

            using (NetworkStream stream = new NetworkStream(client))
            {
                StreamReader streamReader = new StreamReader(stream);
                msg = streamReader.ReadLine();
                ServerParser serverParser = new ServerParser();
                string res = serverParser.Decode(msg);
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {
                    streamWriter.WriteLine(res);
                    MessageBox.Show(res);
                }
                stream.Dispose();
            }
            newsock.Close();
        }

        public void RecieveCsv(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
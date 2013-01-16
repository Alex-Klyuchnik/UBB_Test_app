using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

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
            //IPEndPoint clientep = (IPEndPoint) client.RemoteEndPoint;

            NetworkStream stream = new NetworkStream(client);
            using (StreamReader streamReader = new StreamReader(stream))
            {
                while (streamReader.Peek() >= 0)
                {
                    msg = string.Concat(msg, streamReader.Read());
                }
            }

            ServerParser serverParser = new ServerParser();
            string res = serverParser.Decode(msg);

            using (StreamWriter streamWriter = new StreamWriter(stream))
            {
                streamWriter.WriteLine(res);
            }

            //http://www.java2s.com/Code/CSharp/Network/TcpClientSample.htm //TODO Remove links
            //http://www.java2s.com/Code/CSharp/Network/SimpleTcpServer.htm
        }

        public void Transmit(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
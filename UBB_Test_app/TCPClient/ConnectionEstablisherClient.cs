using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UBB_Test_app.TCPClient
{
    class ConnectionEstablisherClient
    {
        static public string[] ipList = { "127.0.0.1", "192.168.0.101" }; //TODO  move to settings List of server IP
        public string MakeConnect(string parsedString, IPAddress ip)
        {
            TcpClient server;
            string msg="";
            try
            {
                server = new TcpClient(ip.ToString(), 9050); 
                NetworkStream networkStream = server.GetStream();

                //Sending data to server
                using (StreamWriter streamWriter = new StreamWriter(networkStream, Encoding.GetEncoding(1251)))
                {
                    streamWriter.WriteLine(parsedString, Encoding.GetEncoding(1251));
                    streamWriter.Flush();


                    //Recieving data from server
                    if (networkStream.CanRead)
                    {
                        using (StreamReader streamReader = new StreamReader(networkStream))
                        {
                            msg = streamReader.ReadLine();
                        }
                    }
                    else
                    {
                        msg = "Disconnected without confirmation";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                msg = "Error during connection to server";
            }
            return msg;
        }
    }
}

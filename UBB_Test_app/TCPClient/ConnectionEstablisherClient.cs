using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UBB_Test_app.TCPClient
{
    class ConnectionEstablisherClient
    {
        public string MakeConnect(string parsedString)
        {
            TcpClient server;
            string msg="";
            try
            {
                server = new TcpClient("127.0.0.1", 9050); //9050
            }
            catch(SocketException ex)
            {
                MessageBox.Show(ex.Message);
                return "Error during connection to server";
            }
            NetworkStream networkStream = server.GetStream();
            
            //Sending data to server
            //networkStream.Write(Encoding.ASCII.GetBytes(parsedString),0,parsedString.Length);
            using (StreamWriter streamWriter = new StreamWriter(networkStream, Encoding.GetEncoding(1251)))
            {
                streamWriter.WriteLine(parsedString, Encoding.GetEncoding(1251));
                streamWriter.Flush();


                //Recieving data from server
                if (networkStream.CanRead)
                {
                    using (StreamReader streamReader = new StreamReader(networkStream))
                        //TODO Fix msg recieving from server
                    {
                        msg = streamReader.ReadLine();
                    }
                    /*do
                    { 
                        byte[] data = new byte[1024];
                        recv = networkStream.Read(data, 0, data.Length);
                        msg = string.Concat(msg, Encoding.ASCII.GetString(data, 0, recv));
                    } while (networkStream.DataAvailable);*/
                }
                else
                {
                    msg = "Disconnected without confirmation";
                }
            }
            return msg;
        }
    }
}

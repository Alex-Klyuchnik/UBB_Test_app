using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using UBB_Test_app.Entities;
using System.Data.OleDb;
using UBB_Test_app.Properties;
using UBB_Test_app.TCPClient;

namespace UBB_Test_app.DB
{
    public class DBActions
    {
        string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\UBB_Test_app\UBB_Test_app\DB\localDB.accdb;Persist Security Info=True";
        ConnectionEstablisherClient connectionEstablisherClient = new ConnectionEstablisherClient();
        Parser parser = new Parser();
        private IPAddress goodIP;

        internal bool ConnectionCheck()
        {
            Synchronizer synchronizer = new Synchronizer();
            goodIP = synchronizer.GetIPAddress();           //Reset IP to good one
            if (goodIP != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string AddCity(City addedCity)
        {
           string msg = "";
           if (ConnectionCheck())
           {
               msg = connectionEstablisherClient.MakeConnect(parser.AddCityEncode(addedCity),goodIP);
           }
           else
           {
               
               using (OleDbConnection localConn = new OleDbConnection(ConnString))
               {
                   string sql = "insert into Cities(Id, CityName, Region, Country, Attribute) values (?,?,?,?,?)";
                   int newID = LastId() + 1;
                   
                   /*using (OleDbCommand idCMD = new OleDbCommand("SELECT max(Id) FROM Cities", localConn))
                   {
                       localConn.Open();
                       newID = (int) idCMD.ExecuteScalar() + 1;
                   }*/
                  
                   using (OleDbCommand command = new OleDbCommand(sql,localConn))
                   {
                       localConn.Open();
                       command.Parameters.AddWithValue("Id", newID);         
                       command.Parameters.AddWithValue("CityName", addedCity.Name);
                       command.Parameters.AddWithValue("Region", addedCity.Region);
                       command.Parameters.AddWithValue("Country", addedCity.Country);
                       command.Parameters.AddWithValue("Attribute", addedCity.Attrib);
                       command.ExecuteNonQuery();
                       newID++;
                   }
               }
            }
            return msg;
        }

        public string MaxPop ()     
        {
           return connectionEstablisherClient.MakeConnect(parser.MaxPopEncode(),goodIP);
        }

        public string DeleteCity (int id)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.DeleteCityEncode(id),goodIP);
            }
            else
            {
                msg = Resources.NoConnectionToServer;
            }

            return msg;
        }

        public string EditCity (City editedCity)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.EditCityEncode(editedCity),goodIP);
            }
            return msg;
        }

        public string PersonAdd(Person addedPerson)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.AddPersonEncode(addedPerson),goodIP);
            }
            return msg;
        }

        public string PersonEdit(Person changedPerson)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.EditPersonEncode(changedPerson),goodIP);
            }
            return msg;
        }

        public string PersonDelete(int id)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.DeletePersonEncode(id),goodIP);
            }
            return msg;
        }

        public City GetCity(int id)
        {
            City city = new City();
            string sql = string.Concat("select top 1 Id, CityName, Region, Country, Attribute from cities where id=@id");

            using (OleDbConnection connection = new OleDbConnection(ConnString))
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", id);
                    using (OleDbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            city.Id = (int) dataReader[0];
                            city.Name = (string) dataReader[1];
                            city.Region = (string) dataReader[2];
                            city.Country = (string) dataReader[3];
                            city.Attrib = (bool) dataReader[4];
                        }
                    }
                }
            }

            MessageBox.Show(city.Name, "Send city message");
            return city;
        }

        public int LastId()
        {
            int id = -1;
            using (OleDbConnection localConn = new OleDbConnection(ConnString))
            {
                using (OleDbCommand idCMD = new OleDbCommand("SELECT max(Id) FROM Cities", localConn))
                {
                    localConn.Open();
                    id = (int) idCMD.ExecuteScalar();
                }
            }
            return id;
        }

        public string DeleteLocal(int id, string table)
        {
            string msg = Resources.Success;
            string sql = string.Concat("delete from @table where Id=@id");

            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@table", table);
                        command.ExecuteScalar();
                    }
                }
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public string GetReport()
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = SaveReport(parser.ReportDecode(connectionEstablisherClient.MakeConnect(parser.GetReportEncode(),goodIP)));
            }
            return msg;
        }

        public string SaveReport (List<string> list)
        {
            string msg = "";
            try
            {
                File.WriteAllLines(Resources.ReportPath,list);
                msg = string.Concat(Resources.Success," ",Resources.SaveReportMessage," ", Resources.ReportPath);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
    }
}

using System;
using System.Windows.Forms;
using UBB_Test_app.Entities;
using System.Data.OleDb;
using UBB_Test_app.TCPClient;

namespace UBB_Test_app.DB
{
    public class DBActions
    {
        string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\UBB_Test_app\UBB_Test_app\DB\localDB.accdb;Persist Security Info=True";
        ConnectionEstablisherClient connectionEstablisherClient = new ConnectionEstablisherClient();
        Parser parser = new Parser();

        internal bool ConnectionCheck()
        {
            if (connectionEstablisherClient.MakeConnect(parser.TestConnectionEncode()) == "Success")
            {
                return true;
            }
            return false;
        }
        
        public string Add(City addedCity)
        {
           string msg = "";
           if (ConnectionCheck())
           {
               msg = connectionEstablisherClient.MakeConnect(parser.AddCityEncode(addedCity));
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
           return connectionEstablisherClient.MakeConnect(parser.MaxPopEncode());
        }

        public string Delete (int id)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.DeleteCityEncode(id));
            }
            else
            {
                msg = "Нет связи с сервером, попробуйте позже"; //TODO Move to resource file string constants
            }

            return msg;
        }

        public string Edit(City editedCity)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.EditCityEncode(editedCity));
            }
            return msg;
        }

        public string PersonAdd(Person addedPerson)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.AddPersonEncode(addedPerson));
            }
            return msg;
        }

        public string PersonEdit(Person changedPerson)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.EditPersonEncode(changedPerson));
            }
            return msg;
        }

        public string PersonDelete(int id)
        {
            string msg = "";
            if (ConnectionCheck())
            {
                msg = connectionEstablisherClient.MakeConnect(parser.DeletePersonEncode(id));
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

        public string DeleteLocal(int id)
        {
            string msg = "Success";
            string sql = string.Concat("delete from Cities where Id=@id");

            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
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
    }
}

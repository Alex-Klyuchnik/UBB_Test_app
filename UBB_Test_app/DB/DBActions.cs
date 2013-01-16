using System;
using UBB_Test_app.Entities;
using System.Data.OleDb;
using UBB_Test_app.TCPClient;

namespace UBB_Test_app.DB
{
    public class DBActions
    {
        string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\UBB_Test_app\UBB_Test_app\DB\localDB.accdb";
        ConnectionEstablisherClient connectionEstablisherClient = new ConnectionEstablisherClient();
        Parser parser = new Parser();

        internal bool ConnectionCheck()
        {
            return true;       //TODO Realise connection check
        }
        
        internal void Add(City addedCity)
        {
           if (ConnectionCheck())
           {
               connectionEstablisherClient.MakeConnect(parser.AddCityEncode(addedCity));
           }
           else
           {
               
               using (OleDbConnection localConn = new OleDbConnection(ConnString))
               {
                   string sql = "insert into Cities(Id, CityName, Region, Country, Attribute) values (?,?,?,?,?)";
                   int newID;
                   
                   using (OleDbCommand idCMD = new OleDbCommand("SELECT max(Id) FROM Cities", localConn))
                   {
                       localConn.Open();
                       newID = (int) idCMD.ExecuteScalar() + 1;
                   }
                  
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
    }
}

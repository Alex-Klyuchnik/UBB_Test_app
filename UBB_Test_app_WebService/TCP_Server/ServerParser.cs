using System;
using ServerServiceApp.DB;
using ServerServiceApp.Entities;

namespace ServerServiceApp.TCP_Server
{
    public class ServerParser
    {
        public string Decode (string input)
        {
            string msg;
            string opNumber = input.Remove(3);
            DBEdit dbEdit = new DBEdit();

            switch (opNumber)
            {
                case "#01": //Max population asked
                    msg = dbEdit.MaxPop();
                    break;
                case "#02": //Add city to DB 
                    msg = dbEdit.AddCity(DecodeCity(input)) ? "Success" : "Failed";
                    break;
                case "#99": //Testing connection
                    msg = "Success";
                    break;
                
                default:
                    msg = "Unknown operation";
                    break;
            }

            return msg;
        }

        public City DecodeCity(string cityInput) 
        {
            City output = new City();
            char delimiter = '#';
            string[] cityInputSplit = cityInput.Split(delimiter);
            output.Name = cityInputSplit[2];
            output.Region = cityInputSplit[3];
            output.Country = cityInputSplit[4];
            output.Attrib = Convert.ToBoolean(cityInputSplit[5]);
            return output;
        }
    }
}
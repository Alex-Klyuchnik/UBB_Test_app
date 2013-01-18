using System;
using ServerServiceApp.DB;
using ServerServiceApp.Entities;
using ServerServiceApp.Properties;

namespace ServerServiceApp.TCP_Server
{
    public class ServerParser
    {
        private char delimiter = '#';

        public string Decode (string input)
        {
            string msg;
            string opNumber = "";
            if (input.Length > 3)
            {
                opNumber = input.Remove(3);
            }
            
            DBEdit dbEdit = new DBEdit();

            switch (opNumber)
            {
                case "#01": //Max population asked
                    msg = dbEdit.MaxPop();
                    break;
                case "#02": //Add city to DB 
                    msg = dbEdit.AddCity(DecodeCity(input)) ? Resources.Success : Resources.Failed;
                    break;
                case "#03": //Delete city from DB
                    msg = dbEdit.RemoveCity(DecodeID(input)) ? Resources.Success : Resources.Failed;
                    break;
                case "#04": //Edit city by id in DB
                    msg = dbEdit.EditCity(DecodeCity(input).Id, DecodeCity(input)) ? Resources.Success : Resources.Failed;
                    break;
                case "#12": //Add person to DB
                    msg = dbEdit.AddPerson(DecodePerson(input)) ? Resources.Success : Resources.Failed;
                    break;
                case "#13": //Edit person by id DB
                    msg = dbEdit.EditPerson(DecodePerson(input).Id, DecodePerson(input)) ? Resources.Success : Resources.Failed;
                    break;
                case "#14": //Delete person from DB
                    msg = dbEdit.RemovePerson(DecodeID(input)) ? Resources.Success : Resources.Failed;
                    break;
                case "#99": //Testing connection
                    msg = Resources.Success;
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
            //char delimiter = '#';
            string[] cityInputSplit = cityInput.Split(delimiter);
            output.Id = Convert.ToInt32(cityInputSplit[2]);
            output.Name = cityInputSplit[3];
            output.Region = cityInputSplit[4];
            output.Country = cityInputSplit[5];
            output.Attrib = Convert.ToBoolean(cityInputSplit[6]);
            return output;
        }

        public int DecodeID(string input)
        {
            int output;
            output = Convert.ToInt32(input.Remove(0, 4));
            return output;
        }

        public Person DecodePerson (string personInput)
        {
            Person person = new Person();
            string[] personInputSplit = personInput.Split(delimiter);
            person.Id = Convert.ToInt32(personInputSplit[2]);
            person.CityId = Convert.ToInt32(personInputSplit[3]);
            person.FIO = personInputSplit[4];
            return person;
        }
    }
}
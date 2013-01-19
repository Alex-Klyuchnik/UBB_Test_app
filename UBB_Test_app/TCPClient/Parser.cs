using System.Collections.Generic;
using UBB_Test_app.Entities;

namespace UBB_Test_app.TCPClient
{
    public class Parser
    {
        private char delimiter = '#';
        
        public string MaxPopEncode()
        {
            return @"#01#";
        }

        public string AddCityEncode(City city)
        {
            string ret = string.Concat("#02#0#", city.Name, delimiter, city.Region, delimiter, city.Country, delimiter,
                                       city.Attrib.ToString());
            return ret;
        }

        public string DeleteCityEncode (int id)
        {
            string ret = string.Concat("#03#", id.ToString());
            return ret;
        }

        public string TestConnectionEncode()
        {
            return @"#99#";
        }

        public string EditCityEncode(City city)
        {
            string ret = string.Concat("#04#", city.Id.ToString(),delimiter, city.Name , delimiter, city.Region, 
                                       delimiter, city.Country, delimiter, city.Attrib.ToString());
            return ret;
        }

        public string AddPersonEncode(Person person)
        {
            string ret = string.Concat("#12#", person.Id.ToString(), delimiter, person.CityId.ToString(), delimiter,
                                       person.FIO);
            return ret;
        }

        public string EditPersonEncode(Person person)
        {
            string ret = string.Concat("#13#", person.Id.ToString(), delimiter, person.CityId.ToString(), delimiter,
                                       person.FIO);
            return ret;
        }

        public string DeletePersonEncode(int id)
        {
            string ret = string.Concat("#14#", id.ToString());
            return ret;
        }

        public List<string> ReportDecode(string reportPlainString)
        {
            List<string> reportList = new List<string>();
            string[] report = reportPlainString.Split(delimiter);
            foreach (string line in report)
            {
                reportList.Add(line);
            }
            return reportList;
        }

        public string GetReportEncode()
        {
            return "#20#";
        }
    }
}

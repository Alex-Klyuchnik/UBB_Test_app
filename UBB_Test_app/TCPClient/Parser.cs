using UBB_Test_app.Entities;

namespace UBB_Test_app.TCPClient
{
    public class Parser
    {
        public string MaxPopEncode()
        {
            return @"#01#";
        }

        public string AddCityEncode(City city)
        {
            string ret = string.Concat("#02#0#", city.Name, "#", city.Region, "#", city.Country, "#",
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
            string ret = string.Concat("#04#", city.Id.ToString(),"#", city.Name , "#", city.Region, 
                                       "#", city.Country, "#", city.Attrib.ToString());
            return ret;
        }

        public string AddPersonEncode(Person person)
        {
            string ret = string.Concat("#12#", person.Id.ToString(), "#", person.CityId.ToString(), "#",
                                       person.FIO);
            return ret;
        }
    }
}

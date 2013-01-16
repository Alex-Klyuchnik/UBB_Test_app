using Microsoft.VisualStudio.TestTools.UnitTesting;
using UBB_Test_app.Entities;
using UBB_Test_app.TCPClient;


namespace WebServiceUnitTests
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void Should_ConvertCityObject_ToString()
        {
            City city = new City();
            city.Id = 0;
            city.Name = "Donetsk";
            city.Region = "Don";
            city.Country = "UA";
            city.Attrib = false;

            Parser parser = new Parser();
            string res = parser.AddCityEncode(city);
            Assert.AreEqual(res,"#02#0#Donetsk#Don#UA#False");
        }

        [TestMethod]
        public void Should_ConvertPersonObject_ToString()
        {
            Person person = new Person();
            Parser parser = new Parser();

            person.Id = 1;
            person.CityId = 8;
            person.FIO = "Ivanov Petr Olegovich";
            string res = parser.AddPersonEncode(person);
            Assert.AreEqual(res,"#12#1#8#Ivanov Petr Olegovich");
        }
    }
}

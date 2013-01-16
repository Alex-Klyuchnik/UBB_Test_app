using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerServiceApp.TCP_Server;

namespace WebServiceUnitTests
{
    [TestClass]
    public class ServerParserTest
    {
        [TestMethod]
        public void Should_CityNameBeDonetsk_WhenStringContentsItAfter2ndSplitter()
        {
            ServerParser serverParser = new ServerParser();
            Assert.AreEqual(serverParser.DecodeCity("#02#0#Donetsk#Don#UA#False").Name, "Donetsk");
        }

        [TestMethod]
        public void Shoud_AttribBeFalse_WhenStringContentsFalseAfter6thSplitter()
        {
            ServerParser serverParser = new ServerParser();
            Assert.AreEqual(serverParser.DecodeCity("#02#0#Donetsk#Don#UA#False").Attrib, false);
        }

        [TestMethod]
        public void Should_Return32_WhenStringContents32After2ndSplitter()
        {
            ServerParser serverParser = new ServerParser();
            Assert.AreEqual(serverParser.DecodeID("#03#32"), 32);
        }

        [TestMethod]
        public void Should_ReturnUnknownOperation_WhenInputIsDelete()
        {
            ServerParser serverParser = new ServerParser();
            Assert.AreEqual(serverParser.Decode("Delete"), "Unknown operation");
        }

        [TestMethod]
        public void ShouldNot_ThrowException_WhenInputIsEmpty()
        {
            ServerParser serverParser = new ServerParser();
            Assert.AreEqual(serverParser.Decode(""), "Unknown operation");
        }

    }
}

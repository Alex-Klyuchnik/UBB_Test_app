using Microsoft.VisualStudio.TestTools.UnitTesting;
using UBB_Test_app.Features;


namespace WebServiceUnitTests
{
    [TestClass]
    public class InputSanitizerTest
    {
        [TestMethod]
        public void Should_Return143_WhenDirtyStringSanitized()
        {
            InputSanitizer inputSanitizer = new InputSanitizer();
            string res = inputSanitizer.DigitsOnly(@"%1##Udhsgd4&*??/-/3");
            Assert.AreEqual(res,"143");
        }

        [TestMethod]
        public void Should_ReturnCleanName_WhenDirtyStringSanitized()
        {
            InputSanitizer inputSanitizer = new InputSanitizer();
            string res = inputSanitizer.Names(@"Add&&*is-Ab^^:;eb#a 2");
            Assert.AreEqual(res,"Addis-Abeba 2");
        }
    }
}

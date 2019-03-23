using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            char[] str = new char[] {'H','i','!' };
            string cStr=Bbq.ConvertString(str);
            Assert.AreEqual(new string(str),cStr);
        }
    }
}

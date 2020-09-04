using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using srtingexmp2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            string res = p.show("rep");
            string actual = "rep";
            string expected = res;
            Assert.AreEqual(expected, actual);               
        }
    }
}

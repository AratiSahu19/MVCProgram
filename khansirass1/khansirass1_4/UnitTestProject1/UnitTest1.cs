using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using addition;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.add(3, 7);
            int actual = 10;
            int expected = result;
            Assert.AreEqual(expected, actual);
        }
    }
}

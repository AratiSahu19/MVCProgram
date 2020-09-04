using Microsoft.VisualStudio.TestTools.UnitTesting;
using ass8;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = Program.function1(3,2);
            int actual = 9;
            Assert.AreEqual(actual,res);

        }
    }
}

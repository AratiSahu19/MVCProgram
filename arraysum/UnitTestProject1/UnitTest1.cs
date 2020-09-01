using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using arraysum;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            int[] arr1 = { 1, 2 ,3 };
            Program p = new Program();
            int res = p.arraysum(arr1);
            int actual = 6;
            Assert.AreEqual(actual, res);


        }
    }

}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpBusCompany;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 myForm1 = new Form1();

        [TestMethod]
        public void TestMethod1()
        {
            Double Expected = 14.39;

            Double Actual = Math.Round(myForm1.city((Double) 0.8, (Double) 17.99), 2);
            Assert.AreEqual(Expected, Actual);
        }
    }
}

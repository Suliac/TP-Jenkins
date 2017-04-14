using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Jenkins;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(Program.add(2, 3), 5);
        }

        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(Program.div(6, 2), 3);
        }
    }
}

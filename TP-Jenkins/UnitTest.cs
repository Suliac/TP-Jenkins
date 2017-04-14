using NUnit.Framework;
using System;
using TP_Jenkins;

namespace UnitTest
{

    public class UnitTest1
    {
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(Program.add(2, 3), 5);
        }

        [Test]
        public void TestDiv()
        {
            Assert.AreEqual(Program.div(6, 2), 3);
        }
    }
}

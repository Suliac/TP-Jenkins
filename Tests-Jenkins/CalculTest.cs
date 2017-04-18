using NUnit.Framework;
using System;

namespace Tests_Jenkins
{
    [TestFixture]
    public class CalculTest
    {
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(TP_Jenkins.Program.add(2, 3), 5);
        }

        [Test]
        public void TestDiv()
        {
            Assert.AreEqual(TP_Jenkins.Program.div(6, 2), 3);
        }

        //[Test]
        //public void TestDivByZero()
        //{
        //    Assert.Throws<DivideByZeroException>(() => TP_Jenkins.Program.div(6, 0));
        //}
    }
}

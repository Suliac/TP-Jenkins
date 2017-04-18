using NUnit.Framework;
using System;

namespace TestsJenkins
{
    /// <summary>
    /// Test class to test calcul function
    /// </summary>
    [TestFixture]
    public class CalculTest
    {
        /// <summary>
        /// Test method for Add function
        /// </summary>
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(TPJenkins.Program.Add(2, 3), 5);
        }

        /// <summary>
        /// Test method for division function
        /// </summary>
        [Test]
        public void TestDiv()
        {
            Assert.AreEqual(TPJenkins.Program.Div(6, 2), 3);
        }

        //[Test]
        //public void TestDivByZero()
        //{
        //    Assert.Throws<DivideByZeroException>(() => TP_Jenkins.Program.div(6, 0));
        //}
    }
}

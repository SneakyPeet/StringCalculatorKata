using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataStringCalculator
{
    [TestClass]
    public class StringCalculatorUnitTests
    {
        [TestMethod]
        public void GivenBlankThen0()
        {
            int value = StringCalculator.Add("");

            Assert.AreEqual(0, value);
        }

        [TestMethod]
        public void GivenNumberThenNumber()
        {
            int value = StringCalculator.Add("10");

            Assert.AreEqual(10, value);
        }
    }
}

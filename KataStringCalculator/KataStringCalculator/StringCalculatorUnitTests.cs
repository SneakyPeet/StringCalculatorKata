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

        [TestMethod]
        public void GivenTwoNumbersThenNumber()
        {
            int value = StringCalculator.Add("10,11");

            Assert.AreEqual(21, value);
        }

        [TestMethod]
        public void GivenLotsOfNumbersThenNumber()
        {
            int value = StringCalculator.Add("10,11,14,16");

            Assert.AreEqual(51, value);
        }

        [TestMethod]
        public void GivenLotsOfNumbersWithNewLineThenNumber()
        {
            int value = StringCalculator.Add("10\n11,14\n16");

            Assert.AreEqual(51, value);
        }

        [TestMethod]
        public void GivenDifferentDelimiterThenNumber()
        {
            int value = StringCalculator.Add("//;\n1;2");

            Assert.AreEqual(3, value);
        }

        [TestMethod]
        public void GivenNegativeNumbersThenException()
        {
            try
            {
                int value = StringCalculator.Add("//;\n-1;2;-3");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("negatives not allowed -1,-3", ex.Message);
            }
        }      
    }
}

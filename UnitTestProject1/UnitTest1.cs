using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void adding_5_and_6_should_yeild_11()
        {
            var testCalc = new calculator();
            int result = testCalc.addTwoInts(5, 6);

            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void adding_negative_5_and_6_should_yeild_1()
        {
            var testCalc = new calculator();
            int result = testCalc.addTwoInts(-5, 6);

            Assert.AreEqual(1, result);
        }
    }
}

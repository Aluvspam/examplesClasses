using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test_Divide()
        {
            //Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;
            //Act
            int actual = Testing.Maths.Divide(numerator, denominator);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

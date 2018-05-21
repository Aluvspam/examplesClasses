using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;

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

        [TestMethod]

        public void CalculatePowerTest()
        {
            //creez o instanta a clasei PrivateType iar in ctor ii trimit tipul clasei care contine  metoda 
            //instanta PrivateType invoca metoda din clasa Math

            PrivateType obiectPrivat = new PrivateType(typeof(Maths));
            object obj = obiectPrivat.InvokeStatic("calculatePower", 2, 3);
            Assert.AreEqual(8, (int)obj);
        }
        [TestMethod()]

        public void calculatePower1()
        {
            //creez instanta clasei pe care o trimit in ctorul PrivateType
            Maths obiectDeTipulClaseiMaths = new Maths();
            PrivateObject obiectPrivat = new PrivateObject(obiectDeTipulClaseiMaths);
            object obj = obiectPrivat.Invoke("CalculatePower1: ", 2, 3);
            Assert.AreEqual(8,(int)obj);

        }
    }
}

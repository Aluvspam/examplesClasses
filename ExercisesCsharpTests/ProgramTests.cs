﻿using ExercisesCsharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ExercisesCsharp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void NcuN2Test()
        {
            var v = Program.NcuN2(1);
            Assert.AreEqual(v, "+");
        }
        [TestMethod()]
        public void NcuN2Test2()
        {
            var v = Program.NcuN2(2);
            Assert.AreEqual(v, "++" + Environment.NewLine + "++");
        }

        [TestMethod()]
        public void FBTest()
        {
            Assert.AreEqual(Program.FB(11), "11");
            Assert.AreEqual(Program.FB(24), "Fizz");
            Assert.AreEqual(Program.FB(35), "Buzz");
            Assert.AreEqual(Program.FB(60), "FizzBuzz");
        }
        [TestMethod()]
        public void DingleMouseOne()
        {
            //Assert.AreEqual(new int[] { 1, 15, 15 }, Dinglemouse.humanYearsCatYearsDogYears(1));
            Assert.IsTrue((new int[] { 1, 15, 15 }).SequenceEqual(Dinglemouse.humanYearsCatYearsDogYears(1)));
        }

        [TestMethod()]
        public void CeasTest()
        {
            Assert.AreEqual(ExercisesCsharp.Program.Ceas(8, 5), 150);
        }

        [TestMethod()]
        public void unghiCeasTest()
        {
            Assert.AreEqual(ExercisesCsharp.Program.unghiCeas(8, 5), 150);
        }
    }
}
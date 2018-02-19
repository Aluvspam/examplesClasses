using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExercisesCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
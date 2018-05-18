using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Test
    {
        public void CalculatePowerTest()
        {
            PrivateType privateTypeObject = new PrivateType(typeof(Maths));
            object obj = privateTypeObject.InvokeStatic("calculatePower", 2, 10);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Tests
{
    [TestClass()]
    public class LengthTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var Tempreture = new Tempreture(1, MeasureType.cel);
            Assert.AreEqual("1 cel", Tempreture.Verbose());
            Assert.Fail();
        }
    }
}
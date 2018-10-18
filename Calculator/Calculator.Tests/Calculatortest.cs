using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Models;

namespace Calculator.Tests
{
    [TestClass]
    class Calculatortest
    {
        [TestMethod]
        public void Testsuma()
        {
            var s = new Calculadora();
            var result = s.suma(5, 3);
            Assert.AreEqual(8, result);
        }
    }
}

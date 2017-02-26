using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayslip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslip.Model.Tests
{
    [TestClass()]
    public class AmountTests
    {
      

        [TestMethod()]
        public void Amount_PercentageTest()
        {
            var result = Amount.Percentage(9);
            Assert.AreEqual(result.ActualValue, 0.09m);
        }

        [TestMethod()]
        public void Amount_ToStringTest()
        {
            var result = new Amount(100);
            Assert.IsTrue(result.ToString().Equals("100"));
        }
    }
}
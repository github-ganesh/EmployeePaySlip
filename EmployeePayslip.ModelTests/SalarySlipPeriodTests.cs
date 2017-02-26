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
    public class SalarySlipPeriodTests
    {
        [TestMethod()]
        public void SalarySlipPeriod_DateMonth_Format_Test()
        {
            var result = new SalarySlipPeriod("01 March");
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void SalarySlipPeriod_DateMonthDateMonth_Format_Test()
        {
            var result = new SalarySlipPeriod("01 March - 31 March");
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SalarySlipPeriod_ArugumentNullException_Test()
        {
            var result = new SalarySlipPeriod(string.Empty);
            
        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SalarySlipPeriod_InvalidOperationException_Test1()
        {
            var result = new SalarySlipPeriod("31 Feb");

        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SalarySlipPeriod_InvalidOperationException_Test2()
        {
            var result = new SalarySlipPeriod("31 Feb- 31 Feb");

        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SalarySlipPeriod_InvalidDate_Test2()
        {
            var result = new SalarySlipPeriod("31Test");
        }
       
        [TestMethod()]
        public void SalarySlipPeriod_ToString_Test()
        {
            var result = new SalarySlipPeriod("01 March - 31 March");
            Assert.IsTrue(result.ToString().CompareTo("01 March - 31 March")==0);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayslip.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslip.Service.Tests
{
    [TestClass()]
    public class IncomeTaxServiceTests
    {

        [TestMethod()]
        public void IncomeTaxService_CalculateTax_Test1()
        {
            IncomeTaxService service = new IncomeTaxService();
            var result = service.CalculateTax(60050, 2017);
            Assert.IsNotNull(result);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IncomeTaxService_CalculateTax_ArgumentNullException_Test()
        {
            IncomeTaxService service = new IncomeTaxService();
            var result = service.CalculateTax(null, 2017);
        }
        
        [TestMethod()]
        public void IncomeTaxService_CalculateTax_Test2()
        {
            IncomeTaxService service = new IncomeTaxService();
            var result = service.CalculateTax(60050, 2017);
            Assert.AreEqual(result.Tax.RoundOffValue, 11063);
        }
    }
}
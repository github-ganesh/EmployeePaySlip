using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayslip.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslip.Repository.Tests
{
    [TestClass()]
    public class IncomeTaxSlabRepositoryTests
    {
        [TestMethod()]
        public void IncomeTaxSlabRepository_GetTaxationTest()
        {
            IncomeTaxSlabRepository repository = new IncomeTaxSlabRepository();
            var result = repository.GetTaxation(2017);
            Assert.IsNotNull(result);

        }
    }
}
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
    public class EmployeeSalaryRepositoryTests
    {
        [TestMethod()]
        public void EmployeeSalaryRepository_GetEmployeeTest()
        {
            EmployeeSalaryRepository repository = new EmployeeSalaryRepository();
            var employees = repository.GetEmployeeSalary();
            Assert.IsNotNull(employees);
        }
    }
}
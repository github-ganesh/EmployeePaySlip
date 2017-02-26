using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayslip.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayslip.Model;

namespace EmployeePayslip.Service.Tests
{
    [TestClass()]
    public class SalaryCalculationServiceTests
    {
       
        [TestMethod()]
        public void SalaryCalculationService_GetSalaryCalculationTest()
        {
            EmployeeSalaryService test = new EmployeeSalaryService();
            IncomeTaxService test2 = new IncomeTaxService();
            var emp = test.GetEmployeeSalary();
            foreach (var item in emp)
            {
                var taxincome= test2.CalculateTax(item.AnualSalary,2017);
                var payslip = test.GetPaySlip(item, taxincome, new SalarySlipPeriod(1, 3));
            }

            System.Diagnostics.Debug.WriteLine("Test");
        }
    }
}
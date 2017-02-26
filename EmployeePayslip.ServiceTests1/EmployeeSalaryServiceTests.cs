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
    public class EmployeeSalaryServiceTests
    {
       

        [TestMethod()]
        public void EmployeeSalaryService_GetEmployeeSalary_ObjectNotNull_Test()
        {
            EmployeeSalaryService employeeSalaryService = new EmployeeSalaryService();
            var empSalary = employeeSalaryService.GetEmployeeSalary();
            Assert.IsNotNull(empSalary);

        }
        [TestMethod()]
        public void EmployeeSalaryService_GetEmployeeSalary_ObjectCount_Test()
        {
            EmployeeSalaryService employeeSalaryService = new EmployeeSalaryService();
            var empSalary = employeeSalaryService.GetEmployeeSalary();
            Assert.IsTrue(empSalary.Count()==2);

        }
       

        [TestMethod()]
        public void EmployeeSalaryService_GetPaySlipTest()
        {
            EmployeeSalaryService employeeSalaryService = new EmployeeSalaryService();
            var empSalary = employeeSalaryService.GetEmployeeSalary();
            PaySlip paySlip = null;
            foreach (var item in empSalary)
            {
                paySlip = employeeSalaryService.GetPaySlip(item, new Model.IncomeTax() { Tax = (922 * 12), Year = 2017 }, new Model.SalarySlipPeriod(1, 3));
                   break; 
            }
            Assert.IsNotNull(paySlip);
            
        }
    }
}
using EmployeePayslip.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmployeePayslip.Repository
{
    /// <summary>
    /// Employee Salary Repository
    /// </summary>
    public class EmployeeSalaryRepository
    {
        /// <summary>
        /// Gets the employee Salary.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeSalary> GetEmployeeSalary()
        {
            var query = File.ReadLines("Input.txt")
            .SelectMany(line => line.Split(';'))
            .Where(csvLine => !String.IsNullOrWhiteSpace(csvLine))
            .Select(csvLine => new { data = csvLine.Split(',') })
            .Select(s => new EmployeeSalary()
            {
                Employee = new Employee() { FirstName = s.data[0], LastName = s.data[1] },
               AnualSalary =  Convert.ToDecimal(s.data[2]),
                SuperRate = Convert.ToDecimal(s.data[3].Remove(s.data[3].Length-1,1)) ,
                Period = new SalarySlipPeriod(s.data[4])
            });
            return query;
        }
    }
}

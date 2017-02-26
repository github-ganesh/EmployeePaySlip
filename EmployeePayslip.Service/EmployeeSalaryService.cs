using EmployeePayslip.Model;
using EmployeePayslip.Repository;
using System.Collections.Generic;

namespace EmployeePayslip.Service
{
    /// <summary>
    /// Employee Salary Service
    /// </summary>
    public class EmployeeSalaryService
    {
        private const int Month = 12;
        /// <summary>
        /// The employee salary repository
        /// </summary>
        EmployeeSalaryRepository employeeSalaryRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeSalaryService"/> class.
        /// </summary>
        public EmployeeSalaryService()
        {
            employeeSalaryRepository = new EmployeeSalaryRepository();
        }
        /// <summary>
        /// Gets the employee salary details.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeSalary> GetEmployeeSalary()
        {
            return employeeSalaryRepository.GetEmployeeSalary();
        }
        /// <summary>
        /// Gets the pay slip.
        /// </summary>
        /// <param name="employeeSalary">The employee salary.</param>
        /// <param name="incomeTax">The income tax.</param>
        /// <param name="paymentStarPeriod">The payment star period.</param>
        /// <returns></returns>
        public PaySlip GetPaySlip(EmployeeSalary employeeSalary, IncomeTax incomeTax, SalarySlipPeriod paymentStarPeriod)
        {
            return new PaySlip(
                        employeeSalary.Employee,
                        paymentStarPeriod,
                        employeeSalary.AnualSalary / Month,
                        incomeTax.Tax / Month,
                        employeeSalary.SuperRate
             );

        }
    }
}

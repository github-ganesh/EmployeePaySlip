namespace EmployeePayslip.Model
{
    /// <summary>
    /// Employee salary
    /// </summary>
    public class EmployeeSalary
    {
        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        public Employee Employee { get; set; }
        /// <summary>
        /// Gets or sets the anual salary.
        /// </summary>
        /// <value>
        /// The anual salary.
        /// </value>
        public Amount AnualSalary { get; set; }
        /// <summary>
        /// Gets or sets the super rate.
        /// </summary>
        /// <value>
        /// The super rate.
        /// </value>
        public Amount SuperRate { get; set; }
        /// <summary>
        /// Gets or sets the period.
        /// </summary>
        /// <value>
        /// The period.
        /// </value>
        public SalarySlipPeriod Period { get; set; }
    }
}

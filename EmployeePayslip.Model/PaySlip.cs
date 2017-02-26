namespace EmployeePayslip.Model
{
    /// <summary>
    /// PaySlip
    /// </summary>
    public class PaySlip
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaySlip"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <param name="salaryperiod">The salaryperiod.</param>
        /// <param name="grossIncome">The gross income.</param>
        /// <param name="incomeTax">The income tax.</param>
        /// <param name="superRate">The super rate.</param>
        public PaySlip(Employee employee, SalarySlipPeriod salaryperiod, Amount grossIncome, Amount incomeTax, Amount superRate)
        {
            this.Employee = employee;
            this.SalaryPeriod = salaryperiod;
            this.GrossIncome = grossIncome;
            this.IncomeTax = incomeTax;
            this.SuperValue = GrossIncome * Amount.Percentage(superRate);
        }
        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        public Employee Employee { get; private set; }
        /// <summary>
        /// Gets or sets the salary period.
        /// </summary>
        /// <value>
        /// The salary period.
        /// </value>
        public SalarySlipPeriod SalaryPeriod { get; private set; }
        /// <summary>
        /// Gets or sets the gross income.
        /// </summary>
        /// <value>
        /// The gross income.
        /// </value>
        public Amount GrossIncome { get; private set; }
        /// <summary>
        /// Gets or sets the income tax.
        /// </summary>
        /// <value>
        /// The income tax.
        /// </value>
        public Amount IncomeTax { get; private set; }
        /// <summary>
        /// Gets or sets the net income.
        /// </summary>
        /// <value>
        /// The net income.
        /// </value>
        public Amount NetIncome { get { return this.GrossIncome - this.IncomeTax; } }
        /// <summary>
        /// Gets or sets the super value.
        /// </summary>
        /// <value>
        /// The super value.
        /// </value>
        public Amount SuperValue { get; private set; }
    }
}

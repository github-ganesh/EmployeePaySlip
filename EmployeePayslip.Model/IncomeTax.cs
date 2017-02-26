namespace EmployeePayslip.Model
{
    /// <summary>
    /// Income tax
    /// </summary>
    public class IncomeTax
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeTax"/> class.
        /// </summary>
        public IncomeTax()
        {
            Tax = new Amount(0);
        }

        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        /// <value>
        /// The tax.
        /// </value>
        public Amount Tax { get; set; }
        /// <summary>
        /// Gets or sets the taxation year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public int Year { get; set; }
    }
}

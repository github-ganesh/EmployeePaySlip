using EmployeePayslip.Model;
using EmployeePayslip.Repository;
using System;
using System.Linq;

namespace EmployeePayslip.Service
{
    /// <summary>
    /// Income Tax Service
    /// </summary>
    public class IncomeTaxService
    {
        /// <summary>
        /// The income tax slab repository
        /// </summary>
        IncomeTaxSlabRepository incomeTaxSlabRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeTaxService"/> class.
        /// </summary>
        public IncomeTaxService()
        {
            incomeTaxSlabRepository = new IncomeTaxSlabRepository();
        }

        /// <summary>
        /// Calculates the tax.
        /// </summary>
        /// <param name="grossSalary">The gross salary.</param>
        /// <param name="incomeTaxYear">The income tax year.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">amount</exception>
        public IncomeTax CalculateTax(Amount grossSalary, int incomeTaxYear)
        {
            if (grossSalary == null)
                throw new ArgumentNullException("amount");
            var taxableIncome = incomeTaxSlabRepository.GetTaxation(incomeTaxYear);
            IncomeTax incomeTax = new IncomeTax();
            foreach (var item in taxableIncome.TaxSlabs.OrderBy(x=>x.Order))
            {
                if (item.MaxValue >= grossSalary)
                {
                     incomeTax.Tax += ((grossSalary- item.MinValue) * item.Tax);
                     break;
                }
                incomeTax.Tax += ((item.MaxValue - item.MinValue) * item.Tax);
            }
            return incomeTax;

        }
    }
}

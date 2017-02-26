using EmployeePayslip.Model;
using System;
using System.Collections.Generic;

namespace EmployeePayslip.Repository
{
    /// <summary>
    /// Income Tax Slabs Repository
    /// </summary>
    public class IncomeTaxSlabRepository
    {
        /// <summary>
        /// Gets the taxation.
        /// </summary>
        /// <param name="taxationYear">The taxation year.</param>
        /// <returns></returns>
        public TaxableIncome GetTaxation(int taxationYear)
        {
            List<TaxSlab> taxSlabs = new List<TaxSlab>();
            // Get tax slabs for the year 2017 from the data base 
            taxSlabs.Add(new TaxSlab() { Order = 1, MinValue = 0, MaxValue = 18200, Tax = 0.00m });
            taxSlabs.Add(new TaxSlab() { Order = 2, MinValue = 18201, MaxValue = 37000, Tax = .19m });
            taxSlabs.Add(new TaxSlab() { Order = 3, MinValue = 37001, MaxValue = 80000, Tax = .325m });
            taxSlabs.Add(new TaxSlab() { Order = 4, MinValue = 80001, MaxValue = 180000, Tax = .37m });
            taxSlabs.Add(new TaxSlab() { Order = 5, MinValue = 180001, MaxValue = -1, Tax = .45m });
            return new TaxableIncome(taxSlabs, new DateTime(taxationYear, 7, 1));

        }
    }
}

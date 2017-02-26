using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslip.Model
{
    public class TaxableIncome
    {
        private List<TaxSlab> taxslabs;
        public TaxableIncome(List<TaxSlab> taxslabs, DateTime taxationYear)
        {
            this.taxslabs = taxslabs;
            TaxationYear = taxationYear;
        }
        public DateTime TaxationYear { get; private set; }
        public IEnumerable<TaxSlab> TaxSlabs { get { return taxslabs.AsEnumerable<TaxSlab>(); } }
    }
}

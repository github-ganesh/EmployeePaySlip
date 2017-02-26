using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslip.Model
{
    public class TaxSlab
    {
        public int Order { get; set; }
        public Amount MinValue { get; set; }
        public Amount MaxValue { get; set; }
        public Amount Tax { get; set; }
    }
}

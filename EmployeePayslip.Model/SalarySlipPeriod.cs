using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeePayslip.Model
{
   
    public class SalarySlipPeriod
    {
        DateTime datetime;
         
        public SalarySlipPeriod(string paymentStartDate)
        {
            if (String.IsNullOrEmpty(paymentStartDate))
                throw new ArgumentNullException(paymentStartDate);
            if (!paymentStartDate.Contains('-') && Regex.IsMatch(paymentStartDate, @"^(([0-9])|([0-2][0-9])|([3][0-1]))\ +(Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)"))
            {
                DateTime val;
                DateTime.TryParse(paymentStartDate, out val);
                if (val == default(DateTime))
                    throw new InvalidOperationException("paymentStartDate value is invalid");
                datetime = new DateTime(DateTime.Now.Year, val.Month, val.Day);
            }
            else if (paymentStartDate.Contains('-') && Regex.IsMatch(paymentStartDate.Split('-')[0], @"^(([0-9])|([0-2][0-9])|([3][0-1]))\ +(Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)"))
            {
                DateTime val;
                DateTime.TryParse(paymentStartDate.Split('-')[0], out val);
                if (val == default(DateTime))
                    throw new InvalidOperationException("paymentStartDate value is invalid");
                datetime = new DateTime(DateTime.Now.Year, val.Month, val.Day);
            }
            if (datetime == default(DateTime))
                throw new InvalidOperationException("Invlaid date");
        }
        public SalarySlipPeriod(int startDay, int startMonth)
        {
            datetime = new DateTime(DateTime.Now.Year, startMonth, startDay);
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", datetime.ToString("dd MMMM"), new DateTime(datetime.Year, datetime.Month, DateTime.DaysInMonth(datetime.Year, datetime.Month)).ToString("dd MMMM"));

        }

    }
   
  
}

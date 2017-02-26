using System;

namespace EmployeePayslip.Model
{
    /// <summary>
    /// Amount
    /// </summary>
    public class Amount
    {
        /// <summary>
        /// The amount
        /// </summary>
        private decimal amount;
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public Amount(decimal amount)
        {
            this.amount = amount;
        }
        /// <summary>
        /// Gets the actual value.
        /// </summary>
        /// <value>
        /// The actual value.
        /// </value>
        public decimal ActualValue
        {
            get { return amount; }
        }
        /// <summary>
        /// Gets the round off value.
        /// </summary>
        /// <value>
        /// The round off value.
        /// </value>
        public decimal RoundOffValue
        {
            get { return Math.Round(amount); }
        }

        /// <summary>
        /// Implements the operator /.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Amount operator /(Amount value1, Amount value2)
        {
            return new Amount(value1.ActualValue / value2.ActualValue);
        }
        /// <summary>
        /// Percentages the specified value1.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <returns></returns>
        public static Amount Percentage(Amount value1)
        {
            return new Amount(value1.ActualValue / 100);
        }
        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Amount operator *(Amount value1, Amount value2)
        {
            return new Amount(value1.ActualValue * value2.ActualValue);
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Amount operator +(Amount value1, Amount value2)
        {
            return new Amount(value1.ActualValue + value2.ActualValue);
        }
        /// <summary>
        /// Substract.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Amount operator -(Amount value1, Amount value2)
        {
            return new Amount(value1.ActualValue - value2.ActualValue);
        }
        /// <summary>
        /// Less than or equeal to
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator <=(Amount value1, Amount value2)
        {
            return (value1.ActualValue <= value2.ActualValue);
        }
        /// <summary>
        /// Gerater than or equal to 
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator >=(Amount value1, Amount value2)
        {
            return (value1.ActualValue >= value2.ActualValue);
        }
        /// <summary>
        /// Equal to 
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(Amount value1, Amount value2)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(value1, value2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)value1 == null) || ((object)value2 == null))
            {
                return false;
            }

            // Return true if the fields match:
            return value1.ActualValue == value2.ActualValue;
        }
        /// <summary>
        /// Not equal to 
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(Amount value1, Amount value2)
        {
            return !(value1 == value2);
        }

        /// <summary>
        /// Amount <see cref="System.Decimal"/> to <see cref="Amount"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Amount(decimal value)
        {
            return new Amount(value);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> round off Value.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> round off Value.
        /// </returns>
        public override string ToString()
        {
            return RoundOffValue.ToString();
        }
        public override int GetHashCode()
        {
            return amount.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }

}

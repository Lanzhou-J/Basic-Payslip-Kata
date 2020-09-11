using System;
namespace payslip
{
    public class Salary
    {
        private string _currency;
        public decimal Amount { get; private set; }

        public int RoundedAmount { get; private set; }

        public Salary(string currency, decimal amount)
        {
            _currency = currency;
            Amount = amount;
            RoundedAmount = RoundSalary(amount);
        }
        
        public Salary(decimal amount)
        {
            _currency = "AUD";
            Amount = amount;
            RoundedAmount = RoundSalary(amount);
        }

        private int RoundSalary(decimal amount)
        {
            var truncate = Math.Truncate(amount);
            if ((amount - truncate) < (decimal) 0.5)
            {
                return (int)truncate;
            }
            else
            {
                return (int) truncate + 1;
            }
        }        
    }
}
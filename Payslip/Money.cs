using System;
namespace payslip
{
    public class Money
    {
        private string _currency;
        public decimal Amount { get; private set; }

        public int RoundedAmount { get; private set; }

        public Money(string currency, decimal amount)
        {
            _currency = currency;
            Amount = amount;
            RoundedAmount = Round(amount);
        }
        
        public Money(decimal amount)
        {
            _currency = "AUD";
            Amount = amount;
            RoundedAmount = Round(amount);
        }

        private int Round(decimal amount)
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
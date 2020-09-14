using System.Collections.Generic;

namespace payslip
{
    public class TaxRateRule
    {
        public TaxRateRule(int time, Dictionary<double, double> taxableIncomeAndCorrespondingTax)
        {
            Time = time;
            TaxableIncomeAndCorrespondingTax = taxableIncomeAndCorrespondingTax;
        }

        public int Time { get; private set; }
        public Dictionary<double, double> TaxableIncomeAndCorrespondingTax { get; private set; }
    }
}
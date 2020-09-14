using System.Collections.Generic;
namespace payslip

{
    public class TaxRule
    {
        public TaxRule(List<TaxRate> taxRates, string time)
        {
            TaxRates = taxRates;
            Time = time;
        }

        private string Time {get; set; }
        public List<TaxRate> TaxRates { get; private set; }
        
        
    }
}
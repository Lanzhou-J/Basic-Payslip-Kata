using System.Collections.Generic;

namespace payslip
{
    public class Work
    {

        public Money AnnualSalary { get; private set; }
        public int SuperRate { get; private set; }


        public Work( Money annualSalary, int superRate)
        {
            AnnualSalary = annualSalary;
            SuperRate = superRate;
        }
        
        
        public Money GetMonthlySalary()
        {
            Money monthlySalary = Calculator.CalculateMonthlySalary(annualSalary:AnnualSalary);
            return monthlySalary;
        }

        public Money GetTax(List<TaxRate> taxRule)
        {
            var tax = Calculator.CalculateTax(annualSalary: AnnualSalary, taxRule);
            return tax;
        }

        public Money GetNetIncome(List<TaxRate> taxRule)
        {
            var netIncomeAmount = GetMonthlySalary().RoundedAmount -  GetTax(taxRule).RoundedAmount;
            return new Money(amount: netIncomeAmount);
        }
        
        public Money GetSuper()
        {
            var super = Calculator.CalculateSuper(GetMonthlySalary(), SuperRate);
            return super;
        }



    }
}
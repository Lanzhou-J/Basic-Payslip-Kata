using System;
using System.Collections.Generic;

namespace payslip
{
    static class Calculator
    {
      public static Money CalculateTax(Money annualSalary, List<TaxRate> taxRule)
        { double tax = 0;
          int listCount = taxRule.Count;
          double annualSalaryAmount = Decimal.ToDouble(annualSalary.Amount);
          if(annualSalaryAmount<=taxRule[0].UpperBoundary)
          {
            tax = 0;
          }else if (annualSalaryAmount > taxRule[listCount-1].LowerBoundary)
          {
            tax = taxRule[listCount-1].BaseTax + (annualSalaryAmount - taxRule[listCount-1].LowerBoundary)*taxRule[listCount-1].TaxPerUnit/100;
          }else{
            foreach (var item in taxRule)
            {
              if(annualSalaryAmount > item.LowerBoundary && annualSalaryAmount <= item.UpperBoundary){
                tax = item.BaseTax + (annualSalaryAmount - item.LowerBoundary) * item.TaxPerUnit/100;
              }
            }
          }
          double taxPerMonth = tax/12;
          return new Money(amount:Convert.ToDecimal(taxPerMonth));
        }

      public static Money CalculateSuper(Money grossIncome, int superRate){
          double rate = Convert.ToDouble(superRate)/100;
          double super = grossIncome.RoundedAmount * rate;
          int superAmount = Convert.ToInt32(super);
          return new Money(amount: superAmount);
        }
      
      public static Money CalculateMonthlySalary(Money annualSalary)
      {
        decimal monthlySalaryAmount = annualSalary.Amount/12;
        Money monthlySalary = new Money(amount:monthlySalaryAmount);
        return monthlySalary;
      }
    }
}

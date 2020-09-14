using System;
using System.Collections.Generic;

namespace payslip
{
    static class Calculator
    {
      public static Money CalculateTax(Money annualSalary, List<TaxRate> taxRule)
        { double tax;
          double annualSalaryAmount = Decimal.ToDouble(annualSalary.Amount);
          if(annualSalaryAmount<=taxRule[0].UpperBoundary)
          {
            tax = 0;
          }else if(annualSalaryAmount > taxRule[1].LowerBoundary && annualSalaryAmount <= taxRule[1].UpperBoundary){
            tax = taxRule[1].BaseTax + (annualSalaryAmount - taxRule[1].LowerBoundary) * taxRule[1].TaxPerUnit/100;
          }else if(annualSalaryAmount > taxRule[2].LowerBoundary && annualSalaryAmount <= taxRule[2].UpperBoundary){
            tax = taxRule[2].BaseTax + (annualSalaryAmount - taxRule[2].LowerBoundary) * taxRule[2].TaxPerUnit/100;
          }else if(annualSalaryAmount > taxRule[3].LowerBoundary && annualSalaryAmount <= taxRule[3].UpperBoundary){
            tax = taxRule[3].BaseTax + (annualSalaryAmount - taxRule[3].LowerBoundary) * taxRule[3].TaxPerUnit/100;
          }else{
            tax = taxRule[4].BaseTax + (annualSalaryAmount - taxRule[4].LowerBoundary)*taxRule[4].TaxPerUnit/100;
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

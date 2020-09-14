using System;
using System.Collections.Generic;

namespace payslip
{
    static class Calculator
    {
      //This tax rule can change, should modify it.
      public static Money CalculateTax(Money annualSalary)
        { double tax;
          // Dictionary<double, double> taxRate = taxRateRule.TaxableIncomeAndCorrespondingTax;
          double annualSalaryAmount = Decimal.ToDouble(annualSalary.Amount);
          if(annualSalaryAmount<=18200){
            tax = 0;
          }else if(annualSalaryAmount>18200 && annualSalaryAmount<=37000){
            tax = annualSalaryAmount * 0.19;
          }else if(annualSalaryAmount>37000 && annualSalaryAmount<=87000){
            tax = 3572 + (annualSalaryAmount - 37000)*0.325;
          }else if(annualSalaryAmount>87000 && annualSalaryAmount<=180000){
            tax = 19822 + (annualSalaryAmount - 87000)*0.37;
          }else{
            tax = 54232 + (annualSalaryAmount - 54232)*0.45;
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

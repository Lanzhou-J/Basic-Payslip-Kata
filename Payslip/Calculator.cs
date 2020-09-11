using System;
using System.Collections.Generic;

namespace payslip
{
    static class TaxCalculator
    {
      public static Salary CalculateTax(Salary annualSalary)
        { double tax;
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
          return new Salary(amount:Convert.ToDecimal(taxPerMonth));
        }

      // public static int calculateSuper(Dictionary<string, string> userDataSet, int grossIncome){
        //   double rate = double.Parse(userDataSet["superRate"])/100;
        //   double super = grossIncome * rate;
        //   int superInt = Convert.ToInt32(super);
        //   return superInt;
        // }
    }
}

using System;
using System.Collections.Generic;

namespace payslip
{
    class Calculator
    {
      public static int calculateTax(Dictionary<string, string> userDataSet)
        { double tax;
          double annualSalary = double.Parse(userDataSet["annualSalary"]);
          if(annualSalary<=18200){
            tax = 0;
          }else if(annualSalary>18200 && annualSalary<=37000){
            tax = annualSalary * 0.19;
          }else if(annualSalary>37000 && annualSalary<=87000){
            tax = 3572 + (annualSalary - 37000)*0.325;
          }else if(annualSalary>87000 && annualSalary<=180000){
            tax = 19822 + (annualSalary - 87000)*0.37;
          }else{
            tax = 54232 + (annualSalary - 54232)*0.45;
          }
          double taxPerMonth = tax/12;
          int incomeTax = Convert.ToInt32(Math.Ceiling(taxPerMonth));
          return incomeTax;
        }

        public static int calculateNetIncome(int grossIncome, int incomeTax){
          return (grossIncome - incomeTax);
        }

        public static int calculateSuper(Dictionary<string, string> userDataSet, int grossIncome){
          double rate = double.Parse(userDataSet["superRate"])/100;
          double super = grossIncome * rate;
          int superInt = Convert.ToInt32(super);
          return superInt;
        }
    }
}

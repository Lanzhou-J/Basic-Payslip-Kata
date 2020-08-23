using System;
using System.Collections.Generic;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            Tool.greetUser();
            Tool.SeparateCode();

            Dictionary<string, string> userDataSet = new Dictionary<string, string>(); 
            userDataSet = UserInput.UserInputMain();

            int grossIncome = Calculator.calculateGrossIncome(userDataSet);
            int incomeTax = Calculator.calculateTax(userDataSet);
            int netIncome = Calculator.calculateNetIncome(grossIncome, incomeTax);
            int super = Calculator.calculateSuper(userDataSet, grossIncome);

            Dictionary<string, string> paySlipDataSet = new Dictionary<string, string>(); 

            Tool.SeparateCode();
            paySlipDataSet["Name"] = userDataSet["firstname"] + " " + userDataSet["surname"];
            paySlipDataSet["Pay Period"] = userDataSet["paymentStartDate"] + " - " + userDataSet["paymentEndDate"];
            paySlipDataSet["Gross Income"] = grossIncome.ToString();
            paySlipDataSet["Income Tax"] = incomeTax.ToString();
            paySlipDataSet["Net Income"] = netIncome.ToString();
            paySlipDataSet["Super"] = super.ToString();
            
            Tool.PrintDictionary(paySlipDataSet);

            Tool.SeparateCode();
            Tool.thankUser();
            
            // Employee employeeJohn = new Employee("John", "Doe", 60050, 9);
            // Console.WriteLine(employeeJohn.Firstname);
        }
    }
}

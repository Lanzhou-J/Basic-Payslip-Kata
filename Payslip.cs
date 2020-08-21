using System;
using userinput;
using tool;
using calculator;
using System.Collections.Generic;

namespace payslip
{
    class Payslip
    {
        static void Main(string[] args)
        {
            void greetUser(){
              Console.WriteLine("Welcome to the payslip generator!");
            }

            greetUser();
            Tool.SeparateCode();

            Dictionary<string, string> userDataSet = new Dictionary<string, string>(); 
            userDataSet = UserInput.UserInputMain();

            int grossIncome = Calculator.calculateGrossIncome(userDataSet);
            int incomeTax = Calculator.calculateTax(userDataSet);
            int netIncome = Calculator.calculateNetIncome(grossIncome, incomeTax);

            Dictionary<string, string> paySlipDataSet = new Dictionary<string, string>(); 

            Tool.SeparateCode();
            paySlipDataSet["grossIncome"] = grossIncome.ToString();
            paySlipDataSet["incomeTax"] = incomeTax.ToString();
            paySlipDataSet["netIncome"] = netIncome.ToString();

            Tool.PrintDictionary(paySlipDataSet);
        }
    }
}

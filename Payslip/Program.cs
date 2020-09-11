using System;
using System.Collections.Generic;

namespace payslip
{
    class Program
    {
        private static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the payslip generator!");
        }
        
        private static void ThankUser(){
            Console.WriteLine("");
            Console.WriteLine("Thank you for using MYOB!");
        }
        static void Main(string[] args)
        {
            WelcomeUser();
            EmployeeInput newEmployeeInput = new EmployeeInput();

            var adding = true;
            while (adding)
            {
                try
                {
                    Employee newEmployee = newEmployeeInput.CollectUserDetails();
                    Salary annualSalary = newEmployeeInput.CollectSalaryDetails();
                    PaymentPeriod newPaymentPeriod = newEmployeeInput.CollectPaymentDetails();
                    Work newWork = new Work(annualSalary);
                    TaxCalculator newTaxCalculator = new TaxCalculator();

                    Payslip newPayslip = new Payslip(employee:newEmployee, work:newWork, paymentPeriod:newPaymentPeriod);
                    newPayslip.Print();

                    adding = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please try again");
                }
            }
            ThankUser();
        }
    }
}

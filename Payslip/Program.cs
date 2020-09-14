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
            TaxRate taxRateRow1 = new TaxRate(0, 18200,0, 0);
            TaxRate taxRateRow2 = new TaxRate(18200, 37000,19, 0);
            TaxRate taxRateRow3 = new TaxRate(37000, 87000,32.5, 3572);
            TaxRate taxRateRow4 = new TaxRate(87000, 180000,37, 19822);
            TaxRate taxRateRow5 = new TaxRate(180000, -1,37, 54232);
            
            List<TaxRate> taxRule = new List<TaxRate>(){taxRateRow1, taxRateRow2, taxRateRow3, taxRateRow4, taxRateRow5};
            
            WelcomeUser();
            
            EmployeeInput newEmployeeInput = new EmployeeInput();

            var adding = true;
            while (adding)
            {
                try
                {
                    Employee newEmployee = newEmployeeInput.CollectUserDetails();
                    PaymentPeriod newPaymentPeriod = newEmployeeInput.CollectPaymentDetails();
                    Work newWork = newEmployeeInput.CollectWorkDetails();

                    Payslip newPayslip = new Payslip(employee:newEmployee, work:newWork, paymentPeriod:newPaymentPeriod, taxRule);
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

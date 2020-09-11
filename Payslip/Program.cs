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
                    Work newWork = newUserInput.CollectWorkDetails(annualSalary);
                    Calculator newCalculator = new Calculator();

                    EmployeeReport newReport = new EmployeeReport(user:newUser, work:newWork, calculator:newCalculator);
                    newReport.PrintReport();

                    adding = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please try again");
                }
            }
        }
    }
}

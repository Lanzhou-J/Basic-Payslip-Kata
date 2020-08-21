using System;
using userinput;
using tool;

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

            UserInput.UserInputMain();
        }
    }
}

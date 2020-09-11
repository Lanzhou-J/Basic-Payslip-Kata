using System;
using System.Collections.Generic;

namespace payslip
{
    public class EmployeeInput
    {

        private string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        private int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new FormatException("Input was not a number");
            }  
        }
        
        public class InvalidNameException : Exception
        {
            public InvalidNameException()
            {
            }
        
        }

        public void ThrowExceptionWhenNameIsInvalid(string firstname, string surname)
        {
            if (string.IsNullOrEmpty(firstname)||string.IsNullOrEmpty(surname))
            {
                throw new Exception("Name should not be null.");
            }
            
        }

        public Employee CollectUserDetails() {
            var firstname = Ask("Please input your name: ");
            var surname = Ask("Please input your surname: ");
            ThrowExceptionWhenNameIsInvalid(firstname,surname);
            return new Employee(firstname, surname);
        }

    }
}
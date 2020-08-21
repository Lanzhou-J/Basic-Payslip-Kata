using System;
using System.Collections.Generic;
using tool;

namespace userinput
{
    public class UserInput
    {

        public static void UserInputMain()
        {
            string collectUserDataDetail(string inputCategory)
            {
                Console.WriteLine("Please input your " + inputCategory + ":");
                string userInput = Console.ReadLine();
                return userInput;
            }

            Dictionary<string, string> userDataSet = new Dictionary<string, string>(); 

            userDataSet["firstname"] = collectUserDataDetail("firstname");
            userDataSet["surname"] = collectUserDataDetail("surname");
            userDataSet["annualSalary"] = collectUserDataDetail("annual salary");
            userDataSet["superRate"] = collectUserDataDetail("super rate");
            userDataSet["paymentStartDate"] = collectUserDataDetail("payment start date");
            userDataSet["paymentEndDate"] = collectUserDataDetail("payment end date");
            // Console.WriteLine(userDataSet);

            Tool.separateCode();
            Tool.PrintDictionary(userDataSet);
        }

    }
}
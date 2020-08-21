using System;
using System.Collections.Generic; 
// using System.DateTime;

namespace userinput
{
    public class UserInput
    {

        public static void UserInputMain()
        {
            void greetUser(){
              Console.WriteLine("Welcome to the payslip generator!");
            }

            string collectUserDataDetail(string inputCategory)
            {
                Console.WriteLine("Please input your " + inputCategory + ":");
                string userInput = Console.ReadLine();
                return userInput;
            }

            void printDictionary(Dictionary<string, string> userDataSet){
              foreach(KeyValuePair<string, string> keyValuePair in userDataSet){
                Console.WriteLine("Key={0}, Value={1}", keyValuePair.Key, keyValuePair.Value);
              }
            }

            greetUser();

            Dictionary<string, string> userDataSet = new Dictionary<string, string>(); 

            userDataSet["firstname"] = collectUserDataDetail("firstname");
            userDataSet["surname"] = collectUserDataDetail("surname");
            userDataSet["annualSalary"] = collectUserDataDetail("annual salary");
            userDataSet["superRate"] = collectUserDataDetail("super rate");
            userDataSet["paymentStartDate"] = collectUserDataDetail("payment start date");
            userDataSet["paymentEndDate"] = collectUserDataDetail("payment end date");
            // Console.WriteLine(userDataSet);

            printDictionary(userDataSet);
        }

    }
}
using System;
using System.Collections.Generic; 
namespace payslip
{
    public static class Tool
    {
        public static void SeparateCode()
        {
              Console.WriteLine("");
        }
        public static void greetUser(){
            Console.WriteLine("Welcome to the payslip generator!");
          }
        public static void thankUser(){
            Console.WriteLine("Thank you for using MYOB!");
          }
        public static void PrintDictionary(Dictionary<string, string> userDataSet)
        {
          foreach(KeyValuePair<string, string> keyValuePair in userDataSet)
            {
              Console.WriteLine("{0}: {1}", keyValuePair.Key, keyValuePair.Value);
            }
          }
    }
}
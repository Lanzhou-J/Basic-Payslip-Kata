using System;
using System.Collections.Generic; 
namespace tool
{
    public static class Tool
    {
        public static void ToolMain()
        {
            void separateCode(){
              Console.WriteLine("");
            }
            separateCode();
           
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
// using System;
// using System.Collections.Generic; 
namespace payslip
{
    public class Employee
    {
      public string Firstname
      {get; set;}
      public string Lastname
      {get; set;}
      public int AnnualSalary
      {get; set;}
      public int SuperRate
      {get; set;}
      public Employee(string employeeFirstname, string employeeLastname, int employeeAnnualSalary, int employeeSuperRate){
        Firstname = employeeFirstname;
        Lastname = employeeLastname;
        AnnualSalary = employeeAnnualSalary;
        SuperRate = employeeSuperRate;
      }
     
    }
}
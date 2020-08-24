// using System;
// using System.Collections.Generic; 
namespace payslip
{
  public class Payslip
  {
   public string PaymentStartDate
   {get; set;}
   public string PaymentEndDate
   {get; set;}
   public int GrossIncome
   {get; set;}
   public int IncomeTax
   {get; set;}
   public int NetIncome
   {get; set;}
   public int Super
   {get; set;}

   public Employee employee;
   public Payslip(string paymentStartDate, string paymentEndDate, Employee employeeInput){
    employee = employeeInput;
    PaymentStartDate = paymentStartDate;
    PaymentEndDate = paymentEndDate;
   }
  }
}
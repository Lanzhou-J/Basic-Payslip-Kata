using System;
namespace payslip
{
  public class Payslip
  {
      private readonly Employee _employee;
      private readonly Work _work;
      private readonly PaymentPeriod _paymentPeriod;

      public Payslip(Employee employee, Work work, PaymentPeriod paymentPeriod)
      {
          _employee = employee;
          _work = work;
          _paymentPeriod = paymentPeriod;

      }

      public void Print()
      {
          Console.WriteLine();
          Console.WriteLine("Your payslip has been generated:"); 
          Console.WriteLine(); 
          Console.WriteLine("Name: "+ _employee.GetFullname());
          Console.WriteLine("Pay Period: "+ _paymentPeriod.GetPayPeriod());
          Console.WriteLine("Gross Income: "  + _work.CalculateMonthlySalary().RoundedAmount);
          
            
      }
  }

  
}
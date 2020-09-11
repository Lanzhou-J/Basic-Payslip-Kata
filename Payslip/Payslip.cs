using System;
namespace payslip
{
  public class Payslip
  {
      private readonly Employee _employee;
      private readonly Work _work;

      public Payslip(Employee employee, Work work)
      {
          _employee = employee;
          _work = work;
          
      }

      public void Print()
      {
          Console.WriteLine();
          Console.WriteLine("Your payslip has been generated:"); 
          Console.WriteLine(); 
          Console.WriteLine("Name: "+ _employee.GetFullname());
          Console.WriteLine("Gross Income: "  + _work.CalculateMonthlySalary().RoundedAmount);
            
      }
  }

  
}
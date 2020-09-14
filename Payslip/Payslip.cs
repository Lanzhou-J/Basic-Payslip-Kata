using System;
using System.Collections.Generic;

namespace payslip
{
  public class Payslip
  {
      private readonly Employee _employee;
      private readonly Work _work;
      private readonly PaymentPeriod _paymentPeriod;
      private readonly List<TaxRate> _taxRule;

      public Payslip(Employee employee, Work work, PaymentPeriod paymentPeriod, List<TaxRate> taxRule)
      {
          _employee = employee;
          _work = work;
          _paymentPeriod = paymentPeriod;
          _taxRule = taxRule;
      }

      public void Print()
      {
          Console.WriteLine();
          Console.WriteLine("Your payslip has been generated:"); 
          Console.WriteLine(); 
          Console.WriteLine("Name: "+ _employee.GetFullname());
          Console.WriteLine("Pay Period: "+ _paymentPeriod.GetPayPeriod());
          Console.WriteLine("Gross Income: "  + _work.GetMonthlySalary().RoundedAmount);
          Console.WriteLine("Income Tax: " + _work.GetTax(_taxRule).RoundedAmount);
          Console.WriteLine("Net Income: " + _work.GetNetIncome(_taxRule).RoundedAmount);
          Console.WriteLine("Super: "+ _work.GetSuper().RoundedAmount);

      }
  }

  
}
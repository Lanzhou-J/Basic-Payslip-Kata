namespace payslip
{
    public class Work
    {

        public Money AnnualSalary { get; private set; }
        

        public Work( Money annualSalary)
        {
            AnnualSalary = annualSalary;
        }
        
        
        public Money CalculateMonthlySalary()
        {
            decimal monthlySalaryAmount = AnnualSalary.Amount/12;
            Money monthlySalary = new Money(amount:monthlySalaryAmount);
            return monthlySalary;
        }

        public Money GetTax()
        {
            var taxAmount = Calculator.CalculateTax(annualSalary: AnnualSalary);
            return taxAmount;
        }

        public Money GetNetIncome()
        {
            var netIncomeAmount = CalculateMonthlySalary().RoundedAmount -  GetTax().RoundedAmount;
            return new Money(amount: netIncomeAmount);
        }



    }
}
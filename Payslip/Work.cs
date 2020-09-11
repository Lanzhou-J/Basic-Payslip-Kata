namespace payslip
{
    public class Work
    {

        public Salary AnnualSalary { get; private set; }
        

        public Work( Salary annualSalary)
        {
            AnnualSalary = annualSalary;
        }
        
        
        public Salary CalculateMonthlySalary()
        {
            decimal monthlySalaryAmount = AnnualSalary.Amount/12;
            Salary monthlySalary = new Salary(amount:monthlySalaryAmount);
            return monthlySalary;
        }


    }
}
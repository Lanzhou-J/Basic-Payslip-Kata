namespace payslip
{
    public class Work
    {
        public int StartYear { get; private set; }
        public Salary AnnualSalary { get; private set; }
        

        public Work(int startYear, Salary annualSalary)
        {
            StartYear = startYear;
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
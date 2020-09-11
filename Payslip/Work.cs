namespace payslip
{
    public class Work
    {
        public string StartDate { get; private set; }
        public Salary AnnualSalary { get; private set; }
        

        public Work(string startDate, Salary annualSalary)
        {
            StartDate = startDate;
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
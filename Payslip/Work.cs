namespace payslip
{
    public class Work
    {
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }
        public Salary AnnualSalary { get; private set; }
        

        public Work(string startDate, string endDate, Salary annualSalary)
        {
            StartDate = startDate;
            EndDate = endDate;
            AnnualSalary = annualSalary;
            
        }
        
        
        public Salary CalculateMonthlySalary()
        {
            decimal monthlySalaryAmount = AnnualSalary.Amount/12;
            Salary monthlySalary = new Salary(amount:monthlySalaryAmount);
            return monthlySalary;
        }

        public string GetPayPeriod()
        {
            var payPeriod = StartDate + " - " + EndDate;
            return payPeriod;
        }
    }
}
namespace payslip
{
    public class PaymentPeriod
    {
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }

        public PaymentPeriod(string startDate, string endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        
        public string GetPayPeriod()
        {
            var payPeriod = StartDate + " - " + EndDate;
            return payPeriod;
        }
    }
    
}
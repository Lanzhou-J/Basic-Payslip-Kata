namespace payslip
{
    public class TaxRate
    {
        private double LowerBoundary { get; set; }
        private double UpperBoundary { get; set; }
        private double TaxPerUnit { get; set; }
        private double BaseTax { get; set; }

        public TaxRate(double lowerBoundary, double upperBoundary, double taxPerUnit, double baseTax)
        {
            LowerBoundary = lowerBoundary;
            UpperBoundary = upperBoundary;
            TaxPerUnit = taxPerUnit;
            BaseTax = baseTax;
        }

    }
}
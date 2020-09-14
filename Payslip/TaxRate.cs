namespace payslip
{
    public class TaxRate
    {
        public double LowerBoundary { get; private set; }
        public double UpperBoundary { get; private set; }
        public double TaxPerUnit { get; private set; }
        public double BaseTax { get; private set; }

        public TaxRate(double lowerBoundary, double upperBoundary, double taxPerUnit, double baseTax)
        {
            LowerBoundary = lowerBoundary;
            UpperBoundary = upperBoundary;
            TaxPerUnit = taxPerUnit;
            BaseTax = baseTax;
        }

    }
}
namespace MortgageCalculator
{
    public interface ILoan
    {
        public double Principal { get; set; }
        public double YearlyInterestRate { get; set; }
        public int Years { get; set; }
        double CalculateMonthlyPayment();
    }
}

namespace MortgageCalculator
{
    public class BusinessLoan: Loan
    {
        public override double YearlyInterestRate { get; set; } = 0.045;
        public override double Principal { get; set; }
        public override int Years { get; set; }
    }
}

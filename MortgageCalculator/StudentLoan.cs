namespace MortgageCalculator
{
    public class StudentLoan: Loan
    {
        public override double YearlyInterestRate { get; set; } = 0.025;
        public override double Principal { get; set; }
        public override int Years { get; set; }
    }

}

using System;

namespace MortgageCalculator
{
    public class MortgageLoan : Loan
    {
        public override double YearlyInterestRate { get; set; } = 0.032;
        public override double Principal { get; set; }
        public override int Years { get; set; }

    }
}

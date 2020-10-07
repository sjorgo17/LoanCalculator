using System;

namespace MortgageCalculator
{
    public class MortgageLoan : Loan
    {
        public override double YearlyInterestRate { get; set; } = 0.032;

    }
}

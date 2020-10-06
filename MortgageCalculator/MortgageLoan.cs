using System;

namespace MortgageCalculator
{
    public class MortgageLoan : Loan
    {
        private const double _yearlyInterestRate = 0.065;

        public MortgageLoan(double principal, int years)
            :base(principal, _yearlyInterestRate, years)
        {
        }
        public MortgageLoan()
            :base(_yearlyInterestRate)
        {
        }
    }
}

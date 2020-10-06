namespace MortgageCalculator
{
    public class StudentLoan: Loan
    {
        private const double _yearlyInterestRate = 0.0;

        public StudentLoan(double principal, int years)
            : base(principal, _yearlyInterestRate, years)
        {
        }

        public StudentLoan()
            :base(_yearlyInterestRate)
        {
        }
    }

}

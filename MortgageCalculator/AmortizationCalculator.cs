using System;

namespace MortgageCalculator
{
    public class AmortizationCalculator
    {
        private Loan _loan;
        private double _monthlyPayment;

        public AmortizationCalculator(Loan loan)
        {
            _loan = loan;
            _monthlyPayment = loan.CalculateMonthlyPayment() ;
        }

        public void GenerateMonthlyAmortizationSchedule()
        {
            GenerateTableHeader();
            GenerateTableData();
        }

        private void GenerateTableHeader()
        {
            Console.WriteLine("\t\t  Amortization Schedule");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("|Date| \t |Principal| \t |Interest| \t |Balance|");
        }

        private void GenerateTableData()
        {
            const int monthsInYear = 12;

            DateTime date = DateTime.Today;
            var balance = _loan.Principal;
            int months = _loan.Years * monthsInYear;

            for (var i = 0; i < months; i++)
            {
                var interest = (balance * _loan.YearlyInterestRate) / 12;
                var principalPayment = _monthlyPayment - interest;
                balance -= principalPayment;

                Console.WriteLine("{0} \t {1} \t {2} \t {3}", date.AddMonths(i).ToString("MMM-yy"), principalPayment.ToString("C"), interest.ToString("C"), balance.ToString("C"));
            }
        }
    }
    
}

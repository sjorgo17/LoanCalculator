using System;

namespace MortgageCalculator
{
    public class AmortizationCalculator
    {
        private Loan _loan;
        private double _monthlyPayment;
        private double _principal;
        private int _years;

        public AmortizationCalculator(Loan loan, double principal, int years)
        {
            _loan = loan;
            _monthlyPayment = loan.CalculateMonthlyPayment(principal, years) ;
            _principal = principal;
            _years = years;
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
            Console.WriteLine("|Date| \t\t |Principal| \t |Interest| \t |Balance|");
        }

        private void GenerateTableData()
        {
            const int monthsInYear = 12;

            DateTime date = DateTime.Today;
            var balance = _principal;
            int months = _years * monthsInYear;

            for (var i = 0; i < months; i++)
            {
                var interest = (balance * _loan.YearlyInterestRate) / 12;
                var principalPayment = _monthlyPayment - interest;
                balance -= principalPayment;

                Console.WriteLine("{0} \t {1} \t {2} \t {3}", date.AddMonths(i).ToString("MMMM-yyyy"), principalPayment.ToString("C"), interest.ToString("C"), balance.ToString("C"));
            }
        }
    }
    
}

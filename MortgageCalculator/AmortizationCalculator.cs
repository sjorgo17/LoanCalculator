using System;

namespace MortgageCalculator
{
    public class AmortizationCalculator
    {
        private ILoan _loan;
        private double _monthlyPayment;

        public AmortizationCalculator(ILoan loan, double monthlyPayment)
        {
            _loan = loan;
            _monthlyPayment = monthlyPayment;
        }

        public void GenerateMonthlyAmortizationSchedule()
        {
            GenerateTableHeader();
            GenerateTableData();
        }

        private void GenerateTableHeader()
        {
            Console.WriteLine("\t  Amortization Schedule");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("|Date| \t\t |Principal| \t |Interest| \t |Balance|");
        }

        private void GenerateTableData()
        {
            DateTime date = DateTime.Today;
            var balance = _loan.Principal;
            var months = _loan.Years * 12;

            for (var i = 0; i < months; i++)
            {
                var interest = (balance * _loan.YearlyInterestRate) / 12;
                var principalPayment = _monthlyPayment - interest;
                balance -= principalPayment;

                Console.WriteLine("{0} \t {1} \t {2} \t {3}", date.ToString("MMMM-yyyy"), principalPayment.ToString("C"), interest.ToString("C"), balance.ToString("C"));

                date = date.AddMonths(1);
            }
        }
    }
    
}

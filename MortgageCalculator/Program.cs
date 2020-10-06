using System;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal = GetPrincipal();
            double yearlyInterestRate = GetYearlyInterestRate();
            int numberOfYears = GetNumberOfYears();

            MortgageLoan mortgageLoan = new MortgageLoan(principal, yearlyInterestRate, numberOfYears);
            Console.WriteLine(string.Format("Monthly mortgage is: " + mortgageLoan.CalculateMonthlyPayment().ToString("C")));

            AmortizationCalculator amortizationCalculator = new AmortizationCalculator(mortgageLoan);
            amortizationCalculator.GenerateMonthlyAmortizationSchedule();

        }

        private static int GetNumberOfYears()
        {
            Console.WriteLine("Enter number of years: ");
            var inputYears = Console.ReadLine();
            int numberOfYears;

            while (string.IsNullOrEmpty(inputYears) || !int.TryParse(inputYears, out numberOfYears))
            {
                Console.WriteLine("Wrong input! Please try again: ");
                inputYears = Console.ReadLine();
            }

            return numberOfYears;
        }

        private static double GetYearlyInterestRate()
        {
            Console.WriteLine("Enter yearly interest rate: ");
            var inputRate = Console.ReadLine();
            double yearlyInterestRate;

            while (string.IsNullOrEmpty(inputRate) || !double.TryParse(inputRate, out yearlyInterestRate))
            {
                Console.WriteLine("Wrong input! Please try again: ");
                inputRate = Console.ReadLine();
            }

            return yearlyInterestRate;
        }

        private static double GetPrincipal()
        {
            Console.WriteLine("Enter loan's principal: ");
            var inputPrincipal = Console.ReadLine();
            double principal;

            while (string.IsNullOrEmpty(inputPrincipal) || !double.TryParse(inputPrincipal, out principal))
            {
                Console.WriteLine("Wrong input! Please try again: ");
                inputPrincipal = Console.ReadLine();
            }

            return principal;
        }
    }
}
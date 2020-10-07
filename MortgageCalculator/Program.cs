using System;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Loan loan = GetLoanType();
            double principal = GetPrincipal();
            int numberOfYears = GetNumberOfYears();

            Console.WriteLine(string.Format("Monthly payment is: " + loan.CalculateMonthlyPayment(principal,numberOfYears).ToString("C")));

            AmortizationCalculator amortizationCalculator = new AmortizationCalculator(loan, principal, numberOfYears);
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
        private static Loan GetLoanType()
        {
            while (true)
            {
                DisplayMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        return new MortgageLoan();
                    case "2":
                        return new StudentLoan();
                    case "3":
                        return new BusinessLoan();
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Choose a loan type:");
            Console.WriteLine("1) Mortgage");
            Console.WriteLine("2) Student");
            Console.WriteLine("3) Bussiness");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
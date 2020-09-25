using System;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter loan's principal: ");
            var input_Principal = Console.ReadLine();
            float principal;

            while (string.IsNullOrEmpty(input_Principal) || !float.TryParse(input_Principal, out principal))
            {
                Console.WriteLine("Wrong input! Please try again: ");
                input_Principal = Console.ReadLine();
            }

  
            Console.WriteLine("Enter yearly interest rate: ");
            var input_rate = Console.ReadLine();
            float rate;

            while (string.IsNullOrEmpty(input_rate) || !float.TryParse(input_rate, out rate))
            {
                Console.WriteLine("Wrong input! Please try again: ");
                input_rate = Console.ReadLine();
            }


            Console.WriteLine("Enter number of years: ");
            var input_years = Console.ReadLine();
            int years;

            while (string.IsNullOrEmpty(input_years) || !int.TryParse(input_years, out years))
            {
                Console.WriteLine("Wrong input! Please try again: ");
                input_years = Console.ReadLine();
            }

            var monthly_rate = rate / 12;
            var months = years * 12;
            var monthlyMortgage = 0.0;

            if (monthly_rate != 0)
                monthlyMortgage = (monthly_rate * principal * Math.Pow(1 + monthly_rate, months)) / (Math.Pow(1 + monthly_rate, months) - 1);
            else if (monthly_rate == 0)
                monthlyMortgage = principal / months;

            Console.WriteLine(string.Format("Monthly mortgage is: " + monthlyMortgage.ToString("C")));

            amortizationTable(principal, monthlyMortgage, rate, months);

        }

        public static void amortizationTable(float principal, double monthlyMortgage, float rate, float months)
        {
            Console.WriteLine("\t  Amortization Schedule");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("|Month| \t |Interest| \t |Principal|");

            DateTime date = DateTime.Today;
            double amortizationP = principal;


            for (var i = 0; i < months; i++)
            {
                var interest = amortizationP * rate / 12;
                var principal_payment = monthlyMortgage - interest;
                amortizationP = amortizationP - principal_payment;
                Console.WriteLine("{0} \t {1} \t {2}", date.ToString("MMMM-yyyy"), interest.ToString("C"), principal_payment.ToString("C"));
                date = date.AddMonths(1);
            }

        }
    }
}

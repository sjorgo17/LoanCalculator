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

  
            Console.WriteLine("Enter monthly interest rate: ");
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


            var months = years * 12;
            var mounthlyMortgage = 0.0;

            if (rate != 0)
            {
                mounthlyMortgage = (rate * principal * Math.Pow(1 + rate, months))/(Math.Pow(1 + rate, months) - 1);
            }
            else
            {
                mounthlyMortgage = principal / months;
            }

            Console.WriteLine(string.Format("Monthly mortgage is: " + mounthlyMortgage.ToString("C")));
        }
    }
}

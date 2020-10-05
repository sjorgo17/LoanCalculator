using System;

namespace MortgageCalculator
{
    public class MortgageLoan : ILoan
    {
        public double Principal { get; set; }
        public double YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public MortgageLoan(double principal, double yearlyInterestRate, int years)
        {
            Principal = principal;
            YearlyInterestRate = yearlyInterestRate;
            Years = years;
        }
        public double CalculateMonthlyPayment()
        {
            const int MonthsInYear = 12;
            var monthlyInterestRate = YearlyInterestRate / MonthsInYear;
            var months = Years * MonthsInYear;

            double monthlyPayment;
            if (monthlyInterestRate != 0)
                monthlyPayment = (monthlyInterestRate * Principal * Math.Pow(1 + monthlyInterestRate, months)) / (Math.Pow(1 + monthlyInterestRate, months) - 1);
            else
                monthlyPayment = Principal / Years;

            return monthlyPayment;
        }

    }
}

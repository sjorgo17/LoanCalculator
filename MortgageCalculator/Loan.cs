using System;

namespace MortgageCalculator
{
    public abstract class Loan
    { 
    public abstract double YearlyInterestRate { get; set; }

    public double CalculateMonthlyPayment(double principal, int years)
    {
        const int MonthsInYear = 12;
        var monthlyInterestRate = YearlyInterestRate / MonthsInYear;
        var months = years * MonthsInYear;

        double monthlyPayment;

        if (monthlyInterestRate != 0)
            monthlyPayment = (monthlyInterestRate * principal * Math.Pow(1 + monthlyInterestRate, months)) / (Math.Pow(1 + monthlyInterestRate, months) - 1);
        else
            monthlyPayment = principal / months;

        return monthlyPayment;
    }

    }
}


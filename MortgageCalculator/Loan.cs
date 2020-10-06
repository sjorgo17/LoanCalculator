using System;

namespace MortgageCalculator
{
    public abstract class Loan
    { 
    public abstract double Principal { get; set; }
    public abstract double YearlyInterestRate { get; set; }
    public abstract int Years { get; set; }


    public double CalculateMonthlyPayment()
    {
        const int MonthsInYear = 12;
        var monthlyInterestRate = YearlyInterestRate / MonthsInYear;
        var months = Years * MonthsInYear;

        double monthlyPayment = 0.0;
        if (monthlyInterestRate != 0)
            monthlyPayment = (monthlyInterestRate * Principal * Math.Pow(1 + monthlyInterestRate, months)) / (Math.Pow(1 + monthlyInterestRate, months) - 1);
        else
            monthlyPayment = Principal / months;

        return monthlyPayment;
    }

    }
}


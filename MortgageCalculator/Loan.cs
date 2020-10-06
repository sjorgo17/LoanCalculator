using System;

namespace MortgageCalculator
{
    public class Loan
    {

    public double Principal { get; set; }
    public double YearlyInterestRate { get; set; }
    public int Years { get; set; }

    public Loan(double principal, double yearlyInterestRate, int years)
    {
        Principal = principal;
        YearlyInterestRate = yearlyInterestRate;
        Years = years;
    }

    public Loan(double yearlyInterestRate)
    {
        YearlyInterestRate = yearlyInterestRate;
    }

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


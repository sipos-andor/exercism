using System;
using System.Formats.Tar;

static class SavingsAccount
{
    public static Single InterestRate(Decimal balance) =>
        balance switch
        {
            < 0 => 3.213f,
            < 1_000 => 0.5f,
            < 5_000 => 1.621f,
            _ => 2.475f
        };

    public static Decimal Interest(Decimal balance) =>
        (Decimal)(InterestRate(balance) / 100) * balance;

    public static Decimal AnnualBalanceUpdate(Decimal balance) =>
        balance + Interest(balance);

    public static Int32 YearsBeforeDesiredBalance(Decimal balance, Decimal targetBalance)
    {
        Int32 years = 0;
        while (balance < targetBalance)
        {
            ++years;
            balance = AnnualBalanceUpdate(balance);
        };
        return years;
    }
}

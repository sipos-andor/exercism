using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
        => number == number.ToString().Select(c => Math.Pow(int.Parse(c.ToString()), number.ToString().Length)).Sum();
}
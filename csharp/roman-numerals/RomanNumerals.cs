using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumeralExtension
{

    private static readonly IReadOnlyDictionary<string, int> romanDigits = new Dictionary<string, int>
    {
        {"M" , 1000}, {"CM", 900}, {"D", 500}, {"CD", 400},
        {"C", 100}, {"XC", 90}, {"L", 50}, {"XL", 40},
        {"X", 10}, {"IX", 9}, {"V", 5}, {"IV", 4}, {"I", 1}
    };

    public static string ToRoman(this int value)
    {
        var romanNumber =  new StringBuilder();
        foreach (var romanDigit in romanDigits)
        {
            while (value >= romanDigit.Value)
            {
                romanNumber.Append(romanDigit.Key);
                value -= romanDigit.Value;
            }
        }

        return romanNumber.ToString();
    }
}
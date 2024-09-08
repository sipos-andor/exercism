using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect = 0,
    Abundant = 1,
    Deficient = -1
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException("Not a natural number");
        }
        var aliquotSum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                aliquotSum += i;
            }
        }

        switch (number)
        {
            case int n when n < aliquotSum:
                return Classification.Abundant;
            case int n when n > aliquotSum:
                return Classification.Deficient;
            default:
                return Classification.Perfect;
        }
    }
    // public static Classification Classify(int number) =>
    //        (Classification)Enumerable.Range(1, number - 1).Where(x => number % x == 0).Sum().CompareTo(number);

}

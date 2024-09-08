using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
        => (int)Math.Pow(Enumerable.Range(1, max).Sum(), 2);
    public static int CalculateSumOfSquares(int max)
        => Enumerable.Range(1, max).Sum(max => max * max);
    public static double CalculateDifferenceOfSquares(int max)
        => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);

    // public static int CalculateSquareOfSum(int max)
    //     => max * max * (max + 1) * (max + 1) / 4;
    // public static int CalculateSumOfSquares(int max)
    //     => max * (max + 1) * (2 * max + 1) / 6;

}
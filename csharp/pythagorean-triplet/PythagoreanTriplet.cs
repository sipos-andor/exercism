using System;
using System.Collections.Generic;
using System.Linq;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum) =>
         Enumerable.Range(1, sum / 3).SelectMany(a => Enumerable.Range(a + 1, sum / 2)
        .Where(b => a * a + b * b == Math.Pow((sum - a - b), 2))
        .Select(b => (a, b, sum - a - b)));
}
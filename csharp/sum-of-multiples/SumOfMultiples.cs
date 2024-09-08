using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) =>
        Enumerable.Range(1, max - 1).Sum(n => multiples.Any(m => m != 0 && n % m == 0) ? n : 0);
}
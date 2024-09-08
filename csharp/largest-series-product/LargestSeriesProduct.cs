using System;
using System.Globalization;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        var integers = digits.Select(d => CharUnicodeInfo.GetDecimalDigitValue(d)).ToList();
        var numberOfDigits = digits.Count();
        long largestProduct = 0;

        if (numberOfDigits < span || integers.Any(i => i < 0) || span < 0)
            throw new ArgumentException();
        for (var i = 0; i <= numberOfDigits - span; i++)
        {
            long currentProduct = 1;
            for (var j = 0; j < span; j++)
                currentProduct *= integers.ElementAt(i + j);

            if (largestProduct < currentProduct)
                largestProduct = currentProduct;
        }
        return largestProduct;
    }
}
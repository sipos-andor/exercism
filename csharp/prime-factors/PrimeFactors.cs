using System.Collections.Generic;

public static class PrimeFactors
{
    public static IEnumerable<long> Factors(long number)
    {
        long divisor = 2;
        do
        {
            if (number % divisor != 0) ++divisor;
            else
            {
                number /= divisor;
                yield return divisor;
                divisor = 2;
            }
        } while (number > 1);
    }
}
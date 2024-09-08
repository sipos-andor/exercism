using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
        => firstStrand.Length == secondStrand.Length ?
            Enumerable.Range(0, firstStrand.Length).Count(i => firstStrand[i] != secondStrand[i]) :
            throw new ArgumentException($"The parameters {nameof(firstStrand)} and {nameof(secondStrand)} must be same length.");

}
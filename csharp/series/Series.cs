using System;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)=>
        numbers.Length < sliceLength || sliceLength < 1 ?
            throw new ArgumentException($"The argument 'sliceLength' {sliceLength} must be from 1 to length of numbers {numbers.Length}") :
            Enumerable.Range(0, numbers.Length - sliceLength + 1).Select(i => numbers.Substring(i, sliceLength)).ToArray();
}
using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2)
        {
            throw new ArgumentException($"{nameof(inputBase)} cannot be smaller than 2");
        }
        if (outputBase < 2)
        {
            throw new ArgumentException($"{nameof(outputBase)} cannot be smaller than 2");
        }
        if (inputDigits.Any(d => d > inputBase - 1 || d < 0))
        {
            throw new ArgumentException($"Invalid {nameof(inputDigits)}");
        }
        var outputDigits = new List<int>();
        var convertedNumber = 0;
        for (int i = inputDigits.Length - 1; i >= 0; i--)
        {
            convertedNumber += (int)(inputDigits[i] * Math.Pow(inputBase, inputDigits.Length - 1 - i));
        }
        if (convertedNumber == 0)
        {
            outputDigits.Add(convertedNumber);
        }
        while (convertedNumber > 0)
        {
            outputDigits.Add(convertedNumber % outputBase);
            convertedNumber /= outputBase;
        }
        outputDigits.Reverse();
        return outputDigits.ToArray();
    }
}
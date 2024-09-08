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

    // public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    // {
    //     if (inputBase <= 1 || outputBase <= 1) throw new ArgumentException();
    //     int Validate(int digit) => (digit >= inputBase || digit < 0) ? throw new ArgumentException() : digit;

    //     int Unbase() => inputDigits.Reverse().Select((d, i) => Validate(d) * (int)Math.Pow(inputBase, i)).Sum();

    //     int[] Rebase(int value) => ((value < outputBase) ? new int[0] : Rebase(value / outputBase)).Append(value % outputBase).ToArray();

    //     return Rebase(Unbase());
    // }
}
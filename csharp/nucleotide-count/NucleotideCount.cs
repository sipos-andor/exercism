using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var nucleotides = new Dictionary<char, int> { ['A'] = 0, ['C'] = 0, ['G'] = 0, ['T'] = 0 };
        try
        {
            foreach (var nucleotide in sequence)
                ++nucleotides[nucleotide];
        }
        catch (KeyNotFoundException)
        {
            throw new ArgumentException($"Invalid nucleotides");
        }
        return nucleotides;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) => new HashSet<char>(String.Concat(Array.FindAll(input.ToLower().ToCharArray(), char.IsLetter))).Count == 26;
}

//https://exercism.org/tracks/csharp/exercises/pig-latin/approaches/regular-expressions

using System;
using System.Collections.Generic;
using System.Linq;

public static class PigLatin
{
    private static readonly HashSet<string> vowels = ["a", "e", "i", "o", "u"];
    private static readonly HashSet<string> pigLetters = ["xr", "yt", "ay"];

    public static string Translate(string text) => 
        string.Join(" ", from word in text.Split(" ")
                         let firstVowel = vowels.Any(word.Contains) ? vowels.Where(word.Contains).Min(word.IndexOf) : int.MaxValue
                         let firstQu = word.IndexOf("qu")
                         let firstY = word.IndexOf("y")
                         select word switch
                         {
                             _ when vowels.Any(word.StartsWith) || pigLetters.Any(word.StartsWith) => $"{word}ay",
                             _ when firstQu >= 0 && (firstQu < firstVowel) => string.Concat(word.AsSpan(firstQu + 2), word.AsSpan(0, firstQu + 2), "ay"),
                             _ when firstY > 0 && (firstY < firstVowel) => string.Concat(word.AsSpan(firstY), word.AsSpan(0, firstY), "ay"),
                             _ when firstVowel > 0 => string.Concat(word.AsSpan(firstVowel), word.AsSpan(0, firstVowel), "ay"),
                             _ => word
                         });
}
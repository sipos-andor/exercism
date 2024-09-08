using System.Collections.Generic;
using System.Linq;
public static class ProteinTranslation
{
    private static readonly IReadOnlyDictionary<string, string> proteins = new Dictionary<string, string> {
        {"AUG","Methionine"},
        {"UUU","Phenylalanine"},{"UUC","Phenylalanine"},
        {"UUA","Leucine"},{"UUG","Leucine"},
        {"UCU","Serine"},{"UCC","Serine"},{"UCA","Serine"},{"UCG","Serine"},
        {"UAU","Tyrosine"},{"UAC","Tyrosine"},
        {"UGU","Cysteine"},{"UGC","Cysteine"},
        {"UGG","Tryptophan"},
        {"UAA","STOP"},{"UAG","STOP"},{"UGA","STOP"},
    };
    public static string[] Proteins(string strand) =>
        strand.Where((_, s) => s % 3 == 0).Select((_, s) => new string(strand.Skip(s * 3).Take(3).ToArray())).ToArray()
              .TakeWhile(i => proteins[i] != "STOP").Select(i => proteins[i]).ToArray();

}
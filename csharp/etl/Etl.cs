using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
       => old.SelectMany(i => i.Value.Select(letter => (Key: letter.ToLower(), Value: i.Key)))
                .ToDictionary(i => i.Key, i => i.Value);
}
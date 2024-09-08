using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) =>
         string.Concat(phrase.Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.First())).ToUpper();
}
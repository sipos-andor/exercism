using System;
using System.Linq;

public static class Proverb
{
    const string MAIN_SENTENCE_TEMPLATE = "For want of a {0} the {1} was lost.";
    const string LAST_SENTENCE_TEMPLATE = "And all for the want of a {0}.";

    public static string[] Recite(string[] subjects) =>
        subjects.Any() ? subjects.Zip(subjects.Skip(1), (_, __) => String.Format(MAIN_SENTENCE_TEMPLATE, _, __))
                                 .Append(String.Format(LAST_SENTENCE_TEMPLATE, subjects.First())).ToArray()
                       : subjects;

}
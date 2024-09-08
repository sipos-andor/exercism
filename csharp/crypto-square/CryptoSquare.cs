using System;
using System.Collections.Generic;
using System.Linq;

public static class CryptoSquare
{
    public static string NormalizedPlaintext(string plaintext) =>
        plaintext.ToLowerInvariant().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("@", "").Replace("%", "");

    public static IEnumerable<string> PlaintextSegments(string plaintext)
    {
        if (string.IsNullOrEmpty(plaintext))
        {
            return [];
        }
        var normalized = NormalizedPlaintext(plaintext);

        var cols = (int)Math.Ceiling(Math.Sqrt(normalized.Length));
        var rows = (int)Math.Ceiling((double)normalized.Length / cols);

        var missing = cols * rows - normalized.Length;
        normalized += new string(' ', missing);
        return Enumerable.Range(0, rows)
            .Select(i => normalized.Substring(i * cols, Math.Min(cols, normalized.Length - i * rows)));
    }

    public static string Encoded(string plaintext)
    {
        var segments = PlaintextSegments(plaintext).ToArray();
        if (segments is null || segments.Length == 0)
        {
            return string.Empty;
        }
        var coded = new char[segments.Length * segments[0].Length];

        for (var i = 0; i < segments.Length; i++)
        {
            var segmentLenght = segments[i].Length;
            for (int j = 0; j < segmentLenght; j++)
            {
                coded[j * segments.Length + i] = segments[i][j];
            }
        }

        return new string(coded).Replace((char)0, (char)32);
    }

    public static string Ciphertext(string plaintext)
    {
        var encoded = Encoded(plaintext);
        var cols = (int)Math.Ceiling(Math.Sqrt(encoded.Length));
        var rows = (int)Math.Ceiling((double)encoded.Length / cols);

        var cipherSegments = Enumerable.Range(0, cols).Select(i => encoded.Substring(i * rows, Math.Min(rows, encoded.Length - i * rows)));
        var ciphertext = string.Join(" ", cipherSegments);

        return ciphertext;
    }

}
using System;
using System.Collections.Generic;
using System.Linq;

public static class CryptoSquare
{
    public static string NormalizedPlaintext(string plaintext) =>
        new(plaintext.ToLowerInvariant().Where(char.IsLetterOrDigit).ToArray());

    public static IEnumerable<string> PlaintextSegments(string plaintext)
    {
        if (string.IsNullOrEmpty(plaintext))
        {
            return [];
        }
        var normalized = NormalizedPlaintext(plaintext);

        var cols = Cols(normalized.Length);
        var rows = Rows(normalized.Length, cols);

        var missing = cols * rows - normalized.Length;
        normalized += new string(' ', missing);
        return Enumerable.Range(0, rows).Select(i => normalized.Substring(i * cols, Math.Min(cols, normalized.Length - i * rows)));
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
            for (int j = 0; j < segments[i].Length; j++)
            {
                coded[j * segments.Length + i] = segments[i][j];
            }
        }

        return new string(coded);
    }

    public static string Ciphertext(string plaintext)
    {
        var encoded = Encoded(plaintext);
        var cols = Cols(encoded.Length);
        var rows = Rows(encoded.Length, cols);

        return string.Join(" ",
            Enumerable.Range(0, cols).Select(i => encoded.Substring(i * rows, Math.Min(rows, encoded.Length - i * rows))));
    }

    private static int Cols(int length) => (int)Math.Ceiling(Math.Sqrt(length));
    private static int Rows(int length, int? cols = null) => (int)Math.Ceiling((double)length / cols ?? Cols(length));
}
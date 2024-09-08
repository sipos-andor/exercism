using System;
using System.Linq;
using System.Security.Cryptography;

public class SimpleCipher
{
    public SimpleCipher()
        => Key = String.Concat(Enumerable.Range(0, 100).Select(i => Convert.ToChar(RNGCryptoServiceProvider.GetInt32(97, 123))));
    public SimpleCipher(string key) => Key = key;
    public string Key { get; }
    public string Encode(string plaintext)
        => String.Concat(plaintext.Zip(ElongateKey(plaintext.Length), (o, k) => Convert.ToChar((k + o - 97 * 2) % 26 + 97)));
    public string Decode(string ciphertext)
        => String.Concat(ElongateKey(ciphertext.Length).Zip(ciphertext, (k, c) => Convert.ToChar((c - k + 26) % 26 + 97)));
    private string ElongateKey(double inputLength)
        => String.Concat(Enumerable.Range(0, (int)Math.Ceiling(inputLength / (Key.Length))).Select(_ => Key));
}
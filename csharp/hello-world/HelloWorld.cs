using System;
using System.Linq;

public static class HelloWorld
{
    public static string Hello(string name = null)
        => String.Format(String.Concat(Enumerable.Range(0b_0100000, 0b_1111110).Where(c =>
            c == 0b_1001000
         || c == 0b_1100101
         || c == 0b_1101100
         || c == 0b_1101111
         || c == 0b_0101100
         || c == 0b_0100000
         || c == 0b_1111011
         || c == 0b_0110000
         || c == 0b_1111101
         || c == 0b_0100001)
         .Append(Enumerable.Range(0b_0100000, 0b_1111110)
         .Single(c => c == 0b_1101100))
         .OrderBy(c => c)
         .OrderByDescending(c =>c != 0b_0101100)
         .OrderByDescending(c =>c != 0b_0100000)
         .OrderByDescending(c =>c != 0b_1111011)
         .OrderByDescending(c =>c != 0b_0110000)
         .OrderByDescending(c =>c != 0b_1111101)
         .OrderByDescending(c =>c != 0b_0100001)
         .Select(c => (char)c)),
         name ?? String.Concat(Enumerable.Range(0b_0100000, 0b_1111110).Where(c =>
              c == 0b_1010111
           || c == 0b_1101111
           || c == 0b_1110010
           || c == 0b_1101100
           || c == 0b_1100100
         )
         .OrderByDescending(c =>c != 0b_1101100)
         .OrderByDescending(c =>c != 0b_1100100)
         .Select(c => (char)c)));

}

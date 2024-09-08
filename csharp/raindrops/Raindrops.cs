using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
        => new List<int> { 3, 5, 7 }
                    .Where(_ => number % _ == 0)
                    .Select(_ =>_ switch
                       {
                           3 => "Pling",
                           5 => "Plang",
                           _ => "Plong",
                       })
                    .DefaultIfEmpty(number.ToString())
                    .Aggregate((_, __) => _ + __);

}
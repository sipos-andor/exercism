using System;
using System.Linq;
public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown) =>
     String.Join("\n\n", Enumerable.Range(0, takeDown).Reverse().Zip(Enumerable.Range(0, startBottles + 1).Reverse(), (_, __) =>
             String.Format("{0} bottle{2} of beer on the wall, {1} bottle{2} of beer.\n", __ > 0 ? __ : "No more", __ > 0 ? __ : "no more", __ == 1 ? String.Empty : "s") +
             (__ > 0 ? $"Take {(__ > 1 ? "one" : "it")} down and pass it around, {(__ - 1 > 0 ? __ - 1 : "no more")} bottle{((__ - 1) == 1 ? String.Empty : "s")} of beer on the wall." :
                       "Go to the store and buy some more, 99 bottles of beer on the wall.")));
}
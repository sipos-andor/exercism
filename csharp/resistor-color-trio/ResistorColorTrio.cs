using System;
using System.Linq;

public static class ResistorColorTrio
{
    public enum Color { Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Grey, White };
    public static string Label(string[] colors)
    {
        int value = (int)(colors.Take(2).Select(color => (int)Enum.Parse(typeof(Color), color, true))
                        .Aggregate((currentColor, nextColor) => currentColor * 10 + nextColor)
                        * Math.Pow(10, (int)Enum.Parse(typeof(Color), colors.ElementAt(2), true)));
        return (value / 1000 > 0 ? $"{value / 1000} kiloohm{(value == 1000 ? string.Empty : "s")}" : $"{value} ohm{(value == 1 ? string.Empty : "s")}");
    }
}


using System;
using System.Linq;

public static class ResistorColorDuo
{
    public enum Color { Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Grey, White };
    public static int Value(string[] colors)
        =>  colors.Take(2).Select(color => (int)Enum.Parse(typeof(Color), color, true))
            .Aggregate((currentColor, nextColor) => currentColor * 10 + nextColor);
}
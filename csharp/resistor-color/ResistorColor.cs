using System;
using System.Linq;

public static class ResistorColor
{
    public enum Color { Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Grey, White };
    public static int ColorCode(string color) => (int)Enum.Parse(typeof(Color), color, true);
    public static string[] Colors() => Enum.GetNames(typeof(Color)).Select(name=>name.ToLower()).ToArray();
}
using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string input, string delimiter) =>
        input[(input.IndexOf(delimiter) + delimiter.Length)..];

    public static string SubstringBetween(this string input, string start, string end) =>
        input[(input.IndexOf(start) + start.Length)..input.LastIndexOf(end)];

    public static string Message(this string input) =>
        input.SubstringAfter(": ");

    public static string LogLevel(this string input) =>
        input.SubstringBetween("[", "]");
}
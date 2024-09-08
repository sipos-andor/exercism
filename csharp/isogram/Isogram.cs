﻿using System;
using System.Linq;
public static class Isogram
{
    public static bool IsIsogram(string word) =>
        word.ToLower().Replace("-", String.Empty).Replace(" ", String.Empty).Distinct().Count() ==
        word.Replace("-", String.Empty).Replace(" ", String.Empty).Count();
}
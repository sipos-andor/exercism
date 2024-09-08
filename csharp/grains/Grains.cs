using System;

public static class Grains
{
    public static ulong Square(int n) =>
        1 > n || n > 64 ? throw new ArgumentOutOfRangeException($"n out of range: {n}") : 1UL << n-1;

    public static ulong Total() => ulong.MaxValue;
}
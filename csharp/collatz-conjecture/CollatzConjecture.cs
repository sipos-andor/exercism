using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <=0)
            throw new ArgumentOutOfRangeException($"{number} out of range");
        for (int i = 0; true; i++)
        {
            if (number == 1)
                return i;
            number = number % 2 == 0 ? number / 2 : number * 3 + 1;
        }
    }
}
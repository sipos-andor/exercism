﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        return Enumerable.Range(1, rows).Select(row => Row(row));
        IEnumerable<int> Row(int row)
        {
            yield return 1;
            var column = 1;

            for (var j = 1; j < row; j++)
            {
                column = column * (row - j) / j;
                yield return column;
            }
        }
    }

}
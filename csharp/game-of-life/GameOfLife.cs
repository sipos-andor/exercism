public static class GameOfLife
{
    public static int[,] Tick(int[,] matrix)
    {
        int xLength = matrix.GetLength(0);
        int yLength = matrix.GetLength(1);
        int[,] newMatrix = new int[xLength, yLength];
        for (int i = 0; i < xLength; ++i)
        {
            for (int j = 0; j < yLength; ++j)
            {
                int neighbors = 0;
                int x = i - 1;
                for (x = x < 0 ? 0 : x; x <= i + 1 && x < xLength; ++x)
                {
                    int y = j - 1;
                    for (y = y < 0 ? 0 : y; y <= j + 1 && y < yLength; ++y)
                    {
                        if (matrix[x, y] == 1 && !(x == i && y == j) && ++neighbors > 3)
                        {
                            break;
                        }
                    }
                }

                if (neighbors == 2 && matrix[i, j] == 1 || neighbors == 3)
                {
                    newMatrix[i, j] = 1;
                }
            }
        }

        return newMatrix;
    }
}

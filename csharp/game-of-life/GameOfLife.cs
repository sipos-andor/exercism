public static class GameOfLife
{
    public static int[,] Tick(int[,] matrix)
    {
        int xLength = matrix.GetLength(0);
        int yLength = matrix.GetLength(1);
        int[,] nextGeneration = new int[xLength, yLength];
        for (int i = 0; i < xLength; ++i)
        {
            for (int j = 0; j < yLength; ++j)
            {
                int liveNeighbors = 0;
                int x = i - 1;
                for (x = x < 0 ? 0 : x; x <= i + 1 && x < xLength; ++x)
                {
                    int y = j - 1;
                    for (y = y < 0 ? 0 : y; y <= j + 1 && y < yLength; ++y)
                    {
                        if (matrix[x, y] == 1 && !(x == i && y == j) && ++liveNeighbors > 3)
                        {
                            break;
                        }
                    }
                }

                if (liveNeighbors == 2 && matrix[i, j] == 1 || liveNeighbors == 3)
                {
                    nextGeneration[i, j] = 1;
                }
            }
        }

        return nextGeneration;
    }
}

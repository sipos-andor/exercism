public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int numberOfEggs = 0;

        while (encodedCount > 0)
        {
            numberOfEggs += encodedCount % 2;
            encodedCount /= 2;
        }

        return numberOfEggs;
    }
}

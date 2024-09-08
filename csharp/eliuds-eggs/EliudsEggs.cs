public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int numberOfEggs = 0b0;

        while (encodedCount > 0b0)
        {
            numberOfEggs += encodedCount & 0b1;
            encodedCount >>= 0b1;
        }

        return numberOfEggs;
    }
}

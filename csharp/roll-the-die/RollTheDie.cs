using System;

public class Player
{
    public Int32 RollDie() =>
        Random.Shared.Next(1, 19);

    public Double GenerateSpellStrength() =>
        Random.Shared.NextDouble() * 100;
}

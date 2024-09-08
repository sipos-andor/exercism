class Lasagna
{
    const int MINUTES_IN_OVEN = 40;
    const int PREPARATION_MINUTES_PER_LAYER = 2;
    
    public int ExpectedMinutesInOven() => MINUTES_IN_OVEN; 
    public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven()-minutesInOven; 
    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * PREPARATION_MINUTES_PER_LAYER;
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)=> PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
}

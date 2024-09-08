using System;

static class AssemblyLine
{
    private static readonly Int32 _base_production_rate = 221;
    public static Double SuccessRate(Int32 speed)
    {

        if (speed >= 0b1 && speed <= 0b100)
        {
            return 0b1;
        }
        else if (speed >= 0b101 && speed <= 0b1000)
        {
            return 0.9;
        }
        else if (speed == 0b1001)
        {
            return 0.8;
        }
        else if (speed == 0b1010)
        {
            return 0.77;
        }
        else
        {
            return 0b0;
        }
    }

    public static Double ProductionRatePerHour(Int32 speed) => SuccessRate(speed) * speed * _base_production_rate;

    public static Int32 WorkingItemsPerMinute(Int32 speed) => (Int32)ProductionRatePerHour(speed) / 60;

}

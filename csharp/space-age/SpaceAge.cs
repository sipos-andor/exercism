using System;

public class SpaceAge
{
    public const int SECONDS_IN_YEAR = 31_557_600;
    private int seconds;
    public SpaceAge(int seconds) => this.seconds = seconds;
    public double EarthSecondsInYear => SECONDS_IN_YEAR * 1.0;
    public double MercurySecondsInYear => SECONDS_IN_YEAR * 0.2408467;
    public double VenusSecondsInYear => SECONDS_IN_YEAR * 0.61519726;
    public double MarsSecondsInYear => SECONDS_IN_YEAR * 1.8808158;
    public double JupiterSecondsInYear => SECONDS_IN_YEAR * 11.862615;
    public double SaturnSecondsInYear => SECONDS_IN_YEAR * 29.447498;
    public double UranusSecondsInYear => SECONDS_IN_YEAR * 84.016846;
    public double NeptuneSecondsInYear => SECONDS_IN_YEAR * 164.79132;
    public double OnEarth() => seconds / EarthSecondsInYear;
    public double OnMercury() => seconds / MercurySecondsInYear;
    public double OnVenus() => seconds / VenusSecondsInYear;
    public double OnMars() => seconds / MarsSecondsInYear;
    public double OnJupiter() => seconds / JupiterSecondsInYear;
    public double OnSaturn() => seconds / SaturnSecondsInYear;
    public double OnUranus() => seconds / UranusSecondsInYear;
    public double OnNeptune() => seconds / NeptuneSecondsInYear;
}
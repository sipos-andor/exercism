using System;
using System.Diagnostics;
using System.Linq;
public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
        => r.Expreal(realNumber);
}

public struct RationalNumber
{
    private int denominator;
    private int numerator;
    private int? gcd;

    public int Numerator => numerator;
    public int Denominator => denominator;
    public int GCD
    {
        //Binary GCD algorithm
        get
        {
            if (gcd is null)
            {
                int shift = 0;
                int n = Math.Abs(numerator);
                int d = Math.Abs(denominator);
                /* GCD(0,v) == v; GCD(u,0) == u, GCD(0,0) == 0 */
                if (n == 0) return d;
                if (d == 0) return n;

                /* Let shift := lg K, where K is the greatest power of 2
                    dividing both u and v. */
                while (((n | d) & 1) == 0)
                {
                    shift++;
                    n >>= 1;
                    d >>= 1;
                }

                while ((n & 1) == 0)
                    n >>= 1;

                /* From here on, u is always odd. */
                do
                {
                    /* remove all factors of 2 in v -- they are not common */
                    /*   note: v is not zero, so while will terminate */
                    while ((d & 1) == 0)
                        d >>= 1;

                    /* Now u and v are both odd. Swap if necessary so u <= v,
                        then set v = v - u (which is even). For bignums, the
                         swapping is just pointer movement, and the subtraction
                          can be done in-place. */
                    if (n > d)
                    {
                        int t = d; d = n; n = t; // Swap u and v.
                    }

                    d -= n; // Here v >= u.
                } while (d != 0);

                /* restore common factors of 2 */
                gcd = n << shift;
            }
            return gcd.Value;
        }
    }
    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException($"{denominator} cannot be zero.");
        this.numerator = numerator;
        this.denominator = denominator;
        this.gcd = null;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator).Reduce();
    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator).Reduce();
    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator).Reduce();
    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator).Reduce();
    public RationalNumber Abs()
        => new RationalNumber(Math.Abs(numerator), Math.Abs(denominator));
    public RationalNumber Reduce()
    {
        if (denominator < 0)
        {
            numerator *= -1;
            denominator *= -1;
        }
        return new RationalNumber(numerator / GCD, denominator / GCD);
    }
    public RationalNumber Exprational(int power)
        => new RationalNumber((int)Math.Pow(numerator, power), (int)Math.Pow(denominator, power));
    public double Expreal(int baseNumber)
        => Math.Pow(baseNumber, (double)numerator / denominator);
}
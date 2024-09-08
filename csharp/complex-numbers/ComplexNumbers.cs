using System;

public readonly struct ComplexNumber(double real, double imaginary)
{
    private readonly double real = real;
    private readonly double imaginary = imaginary;

    public readonly double Real() => real;
    public readonly double Imaginary() => imaginary;

    public ComplexNumber Mul(ComplexNumber other)
        => new(real * other.real - imaginary * other.imaginary,
                            imaginary * other.real + real * other.imaginary);

    public ComplexNumber Mul(double mulReal)
        => new(real * mulReal, imaginary * mulReal);

    public ComplexNumber Add(ComplexNumber other)
        => new(real + other.real, imaginary + other.imaginary);

    public ComplexNumber Add(double addReal)
        => Add(new ComplexNumber(addReal, 0));

    public ComplexNumber Sub(ComplexNumber other)
         => new(real - other.real, imaginary - other.imaginary);

    public ComplexNumber Sub(double subReal)
         => new(real - subReal, imaginary);

    public ComplexNumber Div(ComplexNumber other)
    {
        var denominator = Math.Pow(other.real, 2) + Math.Pow(other.imaginary, 2);
        return new((real * other.real + imaginary * other.imaginary) / denominator,
                                 (imaginary * other.real - real * other.imaginary) / denominator);
    }
    public ComplexNumber Div(double divReal) =>
        new(real / divReal, imaginary / divReal);

    public double Abs() => Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
    public ComplexNumber Conjugate() => new(real, -imaginary);
    public ComplexNumber Exp()
    {
        var expReal = Math.Pow(Math.E, real);
        return new(expReal * Math.Cos(imaginary),
                            expReal * Math.Sin(imaginary));
    }
}
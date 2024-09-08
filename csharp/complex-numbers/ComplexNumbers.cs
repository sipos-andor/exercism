using System;

public struct ComplexNumber
{
    private double real;
    private double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public double Real() => real;
    public double Imaginary() => imaginary;

    public ComplexNumber Mul(ComplexNumber other)
        => new ComplexNumber(real * other.real - imaginary * other.imaginary,
                            imaginary * other.real + real * other.imaginary);
    public ComplexNumber Add(ComplexNumber other)
        => new ComplexNumber(real + other.real, imaginary + other.imaginary);
    public ComplexNumber Sub(ComplexNumber other)
         => new ComplexNumber(real - other.real, imaginary - other.imaginary);
    public ComplexNumber Div(ComplexNumber other)
    {
        var denominator = Math.Pow(other.real, 2) + Math.Pow(other.imaginary, 2);
        return new ComplexNumber((real * other.real + imaginary * other.imaginary) / denominator,
                                 (imaginary * other.real - real * other.imaginary) / denominator);
    }
    public double Abs() => Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
    public ComplexNumber Conjugate() => new ComplexNumber(real, -imaginary);
    public ComplexNumber Exp()
    {
        var expReal = Math.Pow(Math.E, real);
        return new ComplexNumber(expReal * Math.Cos(imaginary),
                            expReal * Math.Sin(imaginary));
    }
}
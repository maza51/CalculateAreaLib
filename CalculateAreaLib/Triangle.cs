namespace CalculateAreaLib;

public class Triangle : IFigure
{
    private double _sideA, _sideB, _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double GetArea()
    {
        var p = (_sideA + _sideB + _sideC) / 2;

        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }
}


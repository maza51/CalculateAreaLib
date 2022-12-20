namespace CalculateAreaLib;

public class Circle : IFigure
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
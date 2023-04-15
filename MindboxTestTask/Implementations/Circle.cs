using MindboxTestTask.Abstractions;

namespace MindboxTestTask.Implementations;

public class Circle: IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius of a circle cannot be less or equal to zero");
        _radius = radius;
    }

    public double GetSquare() => Math.PI * _radius * _radius;
    public bool IsRectangular() => false;
}
using MindboxTestTask.Abstractions;

namespace MindboxTestTask.Implementations;

public class Triangle : IFigure
{
    private readonly double[] _sides;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("None of a triangle sides can be less or equal to zero");
        if (a > b + c || b > a + c || c > a + b)
            throw new ArgumentException("The side of triangle cannot be less than sum of two others");

        _sides = new[] {a, b, c};
    }

    public double GetSquare()
    {
        var halfOfPerimeter = _sides.Sum() / 2;

        return Math.Sqrt(halfOfPerimeter *
                         (halfOfPerimeter - _sides[0]) *
                         (halfOfPerimeter - _sides[1]) *
                         (halfOfPerimeter - _sides[2]));
    }

    public bool IsRectangular()
    {
        return Math.Pow(_sides[0], 2) == Math.Pow(_sides[1], 2) + Math.Pow(_sides[2], 2)
               || Math.Pow(_sides[1], 2) == Math.Pow(_sides[0], 2) + Math.Pow(_sides[2], 2)
               || Math.Pow(_sides[2], 2) == Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2);
    }
}
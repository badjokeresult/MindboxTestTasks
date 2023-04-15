using System;
using MindboxTestTask.Implementations;
using NUnit.Framework;

namespace MindboxTestTaskTests.Figures;

[TestFixture]
public class TriangleTests
{
    [Test]
    [TestCase(1, 1, -1)]
    [TestCase(1, -1, 1)]
    [TestCase(-1, 1, 1)]
    [TestCase(1, 1, 0)]
    [TestCase(1, 0, 1)]
    [TestCase(0, 1, 1)]
    public void Ctor_OneSideIsNegativeOrZero_ThrowsAnException(double a, double b, double c)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
    }

    [Test]
    [TestCase(1, 1, 3)]
    [TestCase(1, 3, 1)]
    [TestCase(3, 1, 1)]
    public void Ctor_SumOfTwoSidesIsLessThanThirdOne_ThrowsAnException(double a, double b, double c)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
    }

    [Test]
    public void GetSquare_SidesAre3And4And5_6IsReturned()
    {
        var triangle = new Triangle(3, 4, 5);

        var square = triangle.GetSquare();
        
        Assert.AreEqual(6, square);
    }

    [Test]
    public void IsRectangular_SidesAre3And4And5_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRectangular = triangle.IsRectangular();
        
        Assert.IsTrue(isRectangular);
    }

    [Test]
    public void IsRectangular_SidesAre4And5And6_ReturnsFalse()
    {
        var triangle = new Triangle(4, 5, 6);

        var isRectangular = triangle.IsRectangular();
        
        Assert.IsFalse(isRectangular);
    }
}
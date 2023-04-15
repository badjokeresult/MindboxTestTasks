using System;

using MindboxTestTask.Abstractions;
using MindboxTestTask.Implementations;

using NUnit.Framework;

namespace MindboxTestTaskTests.Figures;

[TestFixture]
public class CircleTests
{
    private IFigure circle;
    
    [Test]
    [TestCase(-1)]
    [TestCase(0)]
    public void Ctor_NegativeOrZeroParam_ThrowsAnException(double radius)
    {
        Assert.Throws<ArgumentException>(() => circle = new Circle(radius));
    }

    [Test]
    public void GetSquare_RadiusIs12_144PiIsReturned()
    {
        circle = new Circle(12);

        var square = circle.GetSquare();
        
        Assert.AreEqual(144 * Math.PI, square);
    }
}
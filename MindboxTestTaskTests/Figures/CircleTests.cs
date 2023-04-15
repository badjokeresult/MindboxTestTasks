using System;
using MindboxTestTask.Implementations;
using NUnit.Framework;

namespace MindboxTestTaskTests.Figures;

[TestFixture]
public class CircleTests
{
    [Test]
    public void Ctor_NegativeParam_ThrowsAnException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }

    [Test]
    public void Ctor_ZeroParam_ThrowsAnException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
    }

    [Test]
    public void GetSquare_RadiusIs12_144PiIsReturned()
    {
        var circle = new Circle(12);

        var square = circle.GetSquare();
        
        Assert.AreEqual(144 * Math.PI, square);
    }
}
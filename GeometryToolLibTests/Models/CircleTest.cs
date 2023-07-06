using GeometryToolLib.Models;

namespace GeometryToolLibTests.Models;

public class CircleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CantCreateCircleWithZeroRadius()
    {
        Assert.Throws<ArgumentException>(() => { new Circle(0); });
    }

    [Test]
    public void CanCreateCircleWithNonZeroRadius()
    {
        Assert.Multiple(() =>
        {
            Assert.DoesNotThrow(() => { new Circle(1); });
            Assert.DoesNotThrow(() => { new Circle(-1); });
            Assert.DoesNotThrow(() => { new Circle(5); });
            Assert.DoesNotThrow(() => { new Circle(-5); });
        });
    }
}
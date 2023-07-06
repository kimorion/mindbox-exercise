using GeometryToolLib.Models;

namespace GeometryToolLibTests.Models;

public class TriangleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CantCreateImpossibleTriangle()
    {
        Assert.Multiple(() =>
        {
            Assert.Throws<ArgumentException>(() => { new Triangle(1, 2, 3); });
            Assert.Throws<ArgumentException>(() => { new Triangle(0, 0, 0); });
        });
    }

    [Test]
    public void CanCreatePossibleTriangle()
    {
        Assert.DoesNotThrow(() =>
        {
            var triangles = new[] { new Triangle(1, 1, 1), new Triangle(3, 4, 5) };
        });
    }
}
using GeometryToolLib;
using GeometryToolLib.Models;
using GeometryToolLib.Models.Base;
using GeometryToolLib.Tools.Implementation;

namespace GeometryToolLibTests.Tools.Implementation;

public class AreaToolTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectlyCalculatesArea()
    {
        Figure[] figures =
        {
            new Triangle(3, 4, 5),
            new Triangle(1, 1, 1),
            new Circle(1),
            new Circle(5),
        };
        var areaTool = Toolbox.GetAreaTool();
        var controlResults = new[] { 6, 0.433, 3.141, 78.54 };

        var areas = figures.Select(t => areaTool.GetArea(t)).ToArray();

        const double precision = 0.001;
        Assert.That(areas, Is.EquivalentTo(controlResults).Using<double>((a, b) => Math.Abs(a - b) < precision));
    }
}
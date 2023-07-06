using GeometryToolLib.Models;
using GeometryToolLib.Tools.Implementation;

namespace GeometryToolLibTests.Tools.Implementation;

public class TriangleTypeDetectionToolTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectlyDetectsOrthogonalTriangle()
    {
        var triangles = new[] { new Triangle(1, 1, 1), new Triangle(3, 4, 5) };
        var controlResults = new[] { false, true };
        var triangleTypeTool = new TriangleTypeDetectionTool();
        
        var results = triangles.Select(t => triangleTypeTool.IsOrthogonal(t)).ToArray();

        Assert.That(results, Is.EqualTo(controlResults));
    }
}
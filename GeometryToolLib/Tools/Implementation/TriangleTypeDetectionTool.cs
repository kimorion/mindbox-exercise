using GeometryToolLib.Models;

namespace GeometryToolLib.Tools.Implementation;

internal class TriangleTypeDetectionTool : ITriangleTypeDetectionTool
{
    public bool IsOrthogonal(Triangle triangle)
    {
        var sideLengths = new[] { triangle.SideA, triangle.SideB, triangle.SideC }.OrderDescending().ToArray();

        return Math.Abs(Math.Pow(sideLengths[0], 2) - (Math.Pow(sideLengths[1], 2) + Math.Pow(sideLengths[2], 2))) < 1e-5;
    }
}
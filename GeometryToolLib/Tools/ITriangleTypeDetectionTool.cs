using GeometryToolLib.Models;

namespace GeometryToolLib.Tools;

/// <summary>
/// A tool that identifies the type of triangle
/// </summary>
public interface ITriangleTypeDetectionTool
{
    /// <summary>
    /// Checks if the triangle is orthogonal (right angled)
    /// </summary>
    bool IsOrthogonal(Triangle triangle);
}
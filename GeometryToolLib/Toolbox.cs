using GeometryToolLib.Tools;
using GeometryToolLib.Tools.Implementation;

namespace GeometryToolLib;

/// <summary>
/// Contains Tools for working with figures
/// </summary>
public static class Toolbox
{
    /// <summary>
    /// Get AreaTool
    /// </summary>
    public static IAreaTool GetAreaTool() => new AreaTool();

    /// <summary>
    /// Get TriangleTypeDetectionTool
    /// </summary>
    public static ITriangleTypeDetectionTool GetTriangleTypeDetectionTool() => new TriangleTypeDetectionTool();
}
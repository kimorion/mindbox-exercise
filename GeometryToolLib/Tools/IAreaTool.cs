using GeometryToolLib.Models.Base;

namespace GeometryToolLib.Tools;

/// <summary>
/// A tool for calculating the area of a figure
/// </summary>
public interface IAreaTool
{
    /// <summary>
    /// Get the area of the figure
    /// </summary>
    double GetArea(Figure figure);
}
using GeometryToolLib.Models;
using GeometryToolLib.Models.Base;

namespace GeometryToolLib.Tools.Implementation;

/// <inheritdoc/>
public class AreaTool : IAreaTool
{
    /// <inheritdoc/>
    public double GetArea(Figure figure) => // это же имелось ввиду под "Вычисление без знания типа фигуры в compile-time"?
        figure switch
        {
            Circle circle => GetArea(circle),
            Triangle triangle => GetArea(triangle),
            _ => throw new ArgumentOutOfRangeException(nameof(figure))
        };

    /// <summary>
    /// Calculates the area of a circle by formula: S = PI * R ^ 2
    /// </summary>
    private double GetArea(Circle circle)
    {
        return Math.PI * Math.Pow(circle.Radius, 2);
    }

    /// <summary>
    /// Calculates the area of a triangle by Heron's formula
    /// </summary>
    private static double GetArea(Triangle triangle)
    {
        var semiPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;

        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - triangle.SideA) *
                         (semiPerimeter - triangle.SideB) *
                         (semiPerimeter - triangle.SideC));
    }
}
using GeometryToolLib.Models.Base;

namespace GeometryToolLib.Models;

/// <summary>
/// Triangle with non-zero sides
/// </summary>
public record Triangle : Figure
{
    public Triangle(double SideA, double SideB, double SideC)
    {
        if (!TriangleExists())
        {
            throw new ArgumentException("A triangle with provided side lengths doesn't exist");
        }

        this.SideA = SideA;
        this.SideB = SideB;
        this.SideC = SideC;

        bool TriangleExists() =>
            SideA + SideB > SideC &&
            SideA + SideC > SideB &&
            SideB + SideC > SideA;
    }

    public double SideA { get; init; }
    public double SideB { get; init; }
    public double SideC { get; init; }

    public void Deconstruct(out double SideA, out double SideB, out double SideC)
    {
        SideA = this.SideA;
        SideB = this.SideB;
        SideC = this.SideC;
    }
}
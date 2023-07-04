using GeometryToolLib.Models.Base;

namespace GeometryToolLib.Models;

/// <summary>
/// Circle with a non-zero radius
/// </summary>
public record Circle : Figure
{
    public Circle(float Radius)
    {
        if (Radius == 0)
        {
            throw new ArgumentException("Value can't be zero", nameof(Radius));
        }

        this.Radius = Radius;
    }

    public float Radius { get; init; }

    public void Deconstruct(out float Radius)
    {
        Radius = this.Radius;
    }
}
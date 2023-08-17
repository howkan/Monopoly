namespace Monopoly.Domain.Models.Abstractions;

public abstract class Container
{
    /// <summary>
    /// Ширина.
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// Высота.
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// Вес.
    /// </summary>
    public virtual double Weight { get; set; }

    /// <summary>
    /// Глубина.
    /// </summary>
    public double Depth { get; set; }

    /// <summary>
    /// Объем.
    /// </summary>
    public virtual double Volume { get; set; }
}
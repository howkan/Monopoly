namespace Monopoly.Domain.Models.Abstractions;

/// <summary>
/// Абстрактный класс, представляющий собой любой контейнер, находящийся на складе.
/// </summary>
public abstract class WarehouseContainer : Container
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public Guid Id = Guid.NewGuid();

    /// <summary>
    /// Срок годности.
    /// </summary>
    public virtual DateOnly? ExpirationAt { get; set; }
}
namespace Monopoly.Domain.Models;

public class Box : WarehouseContainer
{
    public override double Volume => Height * Depth * Weight;

    /// <summary>
    /// Дата производства
    /// </summary>
    public DateOnly? ProductionAt { get; set; }

    public override string ToString()
    {
        var hasProductionAt = ProductionAt.HasValue;

        return $"Идентификатор: {Id}\n" +
               $"Ширина: {Width}; Высота: {Height}\n" +
               $"Глубина: {Depth}; Вес: {Weight}; Объём: {Volume}\n" +
               $"Дата производства: {(hasProductionAt ? ProductionAt : "Не задано")}; Срок годности: {ExpirationAt}";
    }
}
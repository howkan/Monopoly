namespace Monopoly.Domain.Models;

public class Pallet : WarehouseContainer
{
    /// <summary>
    /// Коробки, которые находятся внутри паллета.
    /// </summary>
    public List<Box> Boxes { get; set; } = new();

    public override DateOnly? ExpirationAt => Boxes.Any() ? Boxes.Min(box => box.ExpirationAt) : null;

    public override double Volume => (Height * Depth * Width) + Boxes.Sum(box => box.Volume);

    public override double Weight => Boxes.Sum(box => box.Weight) + 30;

    public override string ToString()
    {
        var hasExpirationAt = ExpirationAt.HasValue;

        StringBuilder sb = new();

        sb.AppendLine($"Идентификатор: {Id}")
          .AppendLine($"Ширина: {Width}")
          .AppendLine($"Высота: {Height}")
          .AppendLine($"Глубина: {Depth}")
          .AppendLine($"Вес: {Weight}")
          .AppendLine($"Объём: {Volume}")
          .AppendLine($"Срок годности: {(hasExpirationAt ? ExpirationAt : "Не задано")}")
          .AppendLine($"Количество коробок внутри: {Boxes.Count}");

        if (!Boxes.Any())
        {
            return $"{sb}";
        }

        sb.AppendLine("\nИнформация о коробках:\n");

        for (int i = 0; i < Boxes.Count; i++)
        {
            sb.Append($"\n{i}) {Boxes[i]}\n");
        }

        return $"{sb}";
    }
}
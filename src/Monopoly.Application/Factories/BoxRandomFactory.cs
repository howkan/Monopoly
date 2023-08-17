namespace Monopoly.Application.Factories;

public class BoxRandomFactory : IBoxFactory
{
    private static readonly Random _random = new();

    public Box Create(Pallet pallet)
    {
        DateOnly? productionAt = null;

        DateOnly expiredAt;

        var isContainProductionAt = _random.Next(0, 2) == 0;

        if (isContainProductionAt)
        {
            productionAt = _random.NextDate();
            expiredAt = productionAt.Value.AddDays(100);
        }
        else
        {
            expiredAt = _random.NextDate();
        }

        Box? box = null;

        if (!pallet.Boxes.Any())
        {
            return new()
            {
                Weight = _random.Next(1, (int)pallet.Weight),
                Depth = _random.Next(1, (int)pallet.Depth-1),
                Height = _random.Next(1, (int)pallet.Height),
                Width = _random.Next(1, (int)pallet.Width-1),
                ProductionAt = productionAt,
                ExpirationAt = expiredAt
            };
        }

        var palletBoxes = pallet.Boxes;

        var currentDepth = palletBoxes.Sum(box => box.Depth);

        var currentWidth = palletBoxes.Sum(box => box.Width);

        var width = pallet.Width - currentWidth;

        var depth = pallet.Depth - currentDepth;

        box = new()
        {
            Weight = _random.Next(1, (int)pallet.Weight),
            Depth = _random.Next(1, (int)depth),
            Height = _random.Next(1, (int)pallet.Height),
            Width = _random.Next(1, (int)width),
            ProductionAt = productionAt,
            ExpirationAt = expiredAt
        };

        return box;
    }
}
namespace Monopoly.Application.Factories;

public sealed class PalletRandomFactory : IPalletFactory
{
    private static readonly Random _random = new();

    private readonly IBoxFactory _boxFactory;

    public PalletRandomFactory(IBoxFactory boxFactory)
    {
        _boxFactory = boxFactory;
    }

    public Pallet Create()
    {
        var maxValue = 20;

        var minValue = 5;

        Pallet pallet = new()
        {
            Depth = _random.Next(minValue, maxValue),
            Height = _random.Next(minValue, maxValue),
            Width = _random.Next(minValue, maxValue)
        };

        var boxesCount = _random.Next(0, 4);

        if (boxesCount < 1)
        {
            return pallet;
        }

        for (int i = 0; i < boxesCount; i++)
        {
            var box = _boxFactory.Create(pallet);

            pallet.Boxes.Add(box);
        }

        return pallet;
    }
}
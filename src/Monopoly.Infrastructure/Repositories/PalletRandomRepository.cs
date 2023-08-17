namespace Monopoly.Infrastructure.Repositories;

public sealed class PalletRandomRepository : IPalletRepository
{
    private readonly IPalletFactory _palletFactory;

    public PalletRandomRepository(IPalletFactory palletFactory)
    {
        _palletFactory = palletFactory;
    }

    public IEnumerable<Pallet> Get(int count)
    {
        if(count <= 0)
        {
            return Enumerable.Empty<Pallet>();
        }

        var pallets = new Pallet[count];

        for (int i = 0; i < pallets.Length; i++)
        {
            pallets[i] = _palletFactory.Create();
        }

        return pallets;
    }
}
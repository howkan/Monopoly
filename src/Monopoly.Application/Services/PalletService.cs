namespace Monopoly.Application.Services;

public class PalletService : IPalletService
{
    private readonly IPalletRepository _repository;

    public PalletService(IPalletRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Pallet> GetPallets(int count)
    {
        if(count <= 0)
        {
            return Enumerable.Empty<Pallet>();
        }

        return _repository.Get(count);
    }

    public IEnumerable<Pallet> GroupByExpirationAt(
        IEnumerable<Pallet> pallets) =>
        pallets.OrderByDescending(pallet => pallet.ExpirationAt);
    
    public IEnumerable<Pallet> GroupByExpirationAtAndWeight(
        IEnumerable<Pallet> pallets) =>
        pallets.OrderByDescending(pallet => pallet.ExpirationAt)
        .ThenByDescending(pallet => pallet.Weight);
    
    public IEnumerable<Pallet> GroupByExpirationAtAndVolume(
        IEnumerable<Pallet> pallets) =>
        pallets.OrderByDescending(pallet => pallet.ExpirationAt)
        .ThenByDescending(pallet => pallet.Volume);
}
namespace Monopoly.Domain.Contracts.Services;

public interface IPalletService
{
    /// <summary>
    /// Получить паллеты в количестве <paramref name="count"/>.
    /// </summary>
    /// <param name="count"> Количество паллетов. </param>
    /// <returns> Отсортированная коллекция <see cref="Pallet"/>. </returns>
    public IEnumerable<Pallet> GetPallets(int count);

    /// <summary>
    /// Отсортировать переданные <paramref name="pallets"/> по значению их <see cref="Pallet.ExpirationAt"/>.
    /// </summary>
    /// <param name="pallets"> Паллеты, которые будут отсортированы. </param>
    /// <returns> Отсортированная коллекция <see cref="Pallet"/>. </returns>
    public IEnumerable<Pallet> GroupByExpirationAt(IEnumerable<Pallet> pallets);

    /// <summary>
    /// Отсортировать переданные <paramref name="pallets"/> по значению
    /// их <see cref="Pallet.ExpirationAt"/> и <see cref="Pallet.Weight"/>.
    /// </summary>
    /// <param name="pallets"> Паллеты, которые будут отсортированы. </param>
    /// <returns> Отсортированная коллекция <see cref="Pallet"/>. </returns>
    public IEnumerable<Pallet> GroupByExpirationAtAndWeight(IEnumerable<Pallet> pallets);

    /// <summary>
    /// Отсортировать переданные <paramref name="pallets"/> по значению
    /// их <see cref="Pallet.ExpirationAt"/> и <see cref="Pallet.Volume"/>.
    /// </summary>
    /// <param name="pallets"> Паллеты, которые будут отсортированы. </param>
    /// <returns> Отсортированная коллекция <see cref="Pallet"/>. </returns>
    public IEnumerable<Pallet> GroupByExpirationAtAndVolume(IEnumerable<Pallet> pallets);
}
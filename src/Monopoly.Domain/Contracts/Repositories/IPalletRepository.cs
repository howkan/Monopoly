namespace Monopoly.Domain.Contracts.Repositories;

public interface IPalletRepository
{
    /// <summary>
    /// Получить паллеты в количестве <paramref name="count"/>.
    /// </summary>
    /// <param name="count"> Количество паллетов. </param>
    /// <returns> Отсортированная коллекция <see cref="Pallet"/>. </returns>
    public IEnumerable<Pallet> Get(int count);
}
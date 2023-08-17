namespace Monopoly.Domain.Contracts.Factories;

public interface IBoxFactory
{
    public Box Create(Pallet pallet);
}
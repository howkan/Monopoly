namespace Monopoly.Tests.UnitTests.Repositories;

public sealed class PalletRandomRepositoryTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(5)]
    public void Get(int count)
    {
        // Arrange
        var palletFactory = MockFactories.GetIPalletFactory().Object;

        var palletRepository = new PalletRandomRepository(palletFactory);

        // Act
        var pallets = palletRepository.Get(count);

        // Assert
        if(count > 0)
        {
            Assert.True(pallets.Count() == count);
        }

        Assert.True(pallets.All(pallet => pallet != null));
    }
}
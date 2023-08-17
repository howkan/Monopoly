namespace Monopoly.Tests.UnitTests.Factories;

public sealed class PalletRandomFactoryTests
{
    [Fact]
    public void Create()
    {
        // Arrange
        var boxFactory = MockFactories.GetIBoxFactory().Object;

        var factory = new PalletRandomFactory(boxFactory);

        // Act
        var pallet = factory.Create();

        // Assert
        Assert.True(pallet != null);

        Assert.True(pallet.Depth > 0);

        Assert.True(pallet.Height > 0);

        Assert.True(pallet.Width > 0);

        Assert.True(pallet.Depth > 0);
    }
}
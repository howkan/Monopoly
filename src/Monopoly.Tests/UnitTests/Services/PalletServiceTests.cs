namespace Monopoly.Tests.UnitTests.Services;

public sealed class PalletServiceTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(5)]
    public void GetPallets(int count)
    {
        // Arrange
        var palletRepository = MockRepositories.GetIPalletRepository().Object;

        var palletService = new PalletService(palletRepository);

        // Act
        var pallets = palletService.GetPallets(count);

        // Assert
        if (count > 0)
        {
            Assert.True(pallets.Count() == count);
        }

        Assert.True(pallets.All(pallet => pallet != null));
    }

    [Fact]
    public void GroupByExpirationAt()
    {
        // Arrange
        var palletRepository = MockRepositories.GetIPalletRepository().Object;

        var palletService = new PalletService(palletRepository);

        List<Pallet> pallets = new()
        {
            new() { Boxes = new List<Box> { new () { ExpirationAt = new DateOnly(2023, 1, 3) } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 1) } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 2) } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = null } } }
        };

        // Act
        var sortedPallets = palletService.GroupByExpirationAt(pallets).ToArray();

        // Assert
        Assert.NotNull(sortedPallets);

        Assert.Equal(pallets[0], sortedPallets[0]);
        Assert.Equal(pallets[2], sortedPallets[1]);
        Assert.Equal(pallets[1], sortedPallets[2]);
        Assert.Equal(pallets[3], sortedPallets[3]);
    }

    [Fact]
    public void GroupByExpirationAtAndWeight()
    {
        // Arrange
        var palletRepository = MockRepositories.GetIPalletRepository().Object;

        var palletService = new PalletService(palletRepository);

        List<Pallet> pallets = new()
        {
            new() { Boxes = new List<Box> { new () { ExpirationAt = new DateOnly(2023, 1, 3), Weight = 2 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 1), Weight = 2 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 2), Weight = 2 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = null, Weight = 10 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 4), Weight = 1 } } }
        };

        // Act
        var sortedPallets = palletService.GroupByExpirationAtAndWeight(pallets).ToArray();

        // Assert
        Assert.NotNull(sortedPallets);

        Assert.Equal(pallets[4], sortedPallets[0]);
        Assert.Equal(pallets[0], sortedPallets[1]);
        Assert.Equal(pallets[2], sortedPallets[2]);
        Assert.Equal(pallets[1], sortedPallets[3]);
        Assert.Equal(pallets[3], sortedPallets[4]);
    }

    [Fact]
    public void GroupByExpirationAtAndVolume()
    {
        // Arrange
        var palletRepository = MockRepositories.GetIPalletRepository().Object;

        var palletService = new PalletService(palletRepository);

        List<Pallet> pallets = new()
        {
            new() { Boxes = new List<Box> { new () { ExpirationAt = new DateOnly(2023, 1, 3), Volume = 2 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 1), Volume = 2 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 2), Volume = 2 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = null, Volume = 10 } } },
            new() { Boxes = new List<Box> { new() { ExpirationAt = new DateOnly(2023, 1, 4), Volume = 1 } } }
        };

        // Act
        var sortedPallets = palletService.GroupByExpirationAtAndVolume(pallets).ToArray();

        // Assert
        Assert.NotNull(sortedPallets);

        Assert.Equal(pallets[4], sortedPallets[0]);
        Assert.Equal(pallets[0], sortedPallets[1]);
        Assert.Equal(pallets[2], sortedPallets[2]);
        Assert.Equal(pallets[1], sortedPallets[3]);
        Assert.Equal(pallets[3], sortedPallets[4]);
    }
}
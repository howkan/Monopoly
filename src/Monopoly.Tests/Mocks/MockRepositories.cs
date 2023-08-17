namespace Monopoly.Tests.Mocks;

public static class MockRepositories
{
    public static Mock<IPalletRepository> GetIPalletRepository()
    {
        Mock<IPalletRepository> mockFactory = new();

        mockFactory.Setup(behaviour => behaviour.Get(5))
            .Returns(value: new List<Pallet>()
            {
                new()
                {
                    Width = 10,
                    Height = 10,
                    Depth = 10,
                    Boxes =
                    {
                        new()
                        {
                            Depth = 2,
                            ExpirationAt = new DateOnly(2023, 3, 10),
                            ProductionAt = new DateOnly(2023, 1, 1),
                            Height = 2,
                            Weight = 2,
                            Width = 2
                        }
                    }
                },
                new()
                {
                    Width = 10,
                    Height = 10,
                    Depth = 10,
                    Boxes =
                    {
                        new()
                        {
                            Depth = 2,
                            ExpirationAt = new DateOnly(2023, 3, 10),
                            ProductionAt = new DateOnly(2023, 1, 1),
                            Height = 2,
                            Weight = 2,
                            Width = 2
                        }
                    }
                },
                new()
                {
                    Width = 10,
                    Height = 10,
                    Depth = 10,
                    Boxes =
                    {
                        new()
                        {
                            Depth = 2,
                            ExpirationAt = new DateOnly(2023, 3, 10),
                            ProductionAt = new DateOnly(2023, 1, 1),
                            Height = 2,
                            Weight = 2,
                            Width = 2
                        }
                    }
                },
                new()
                {
                    Width = 10,
                    Height = 10,
                    Depth = 10,
                    Boxes =
                    {
                        new()
                        {
                            Depth = 2,
                            ExpirationAt = new DateOnly(2023, 3, 10),
                            ProductionAt = new DateOnly(2023, 1, 1),
                            Height = 2,
                            Weight = 2,
                            Width = 2
                        }
                    }
                },
                new()
                {
                    Width = 10,
                    Height = 10,
                    Depth = 10,
                    Boxes =
                    {
                        new()
                        {
                            Depth = 2,
                            ExpirationAt = new DateOnly(2023, 3, 10),
                            ProductionAt = new DateOnly(2023, 1, 1),
                            Height = 2,
                            Weight = 2,
                            Width = 2
                        }
                    }
                }
            });

        mockFactory.Setup(behaviour => behaviour.Get(1))
            .Returns(value: new List<Pallet>()
            {
                new()
                {
                    Width = 10,
                    Height = 10,
                    Depth = 10,
                    Boxes =
                    {
                        new()
                        {
                            Depth = 2,
                            ExpirationAt = new DateOnly(2023, 3, 10),
                            ProductionAt = new DateOnly(2023, 1, 1),
                            Height = 2,
                            Weight = 2,
                            Width = 2
                        }
                    }
                }
            });

        mockFactory.Setup(behaviour => behaviour.Get(0))
            .Returns(value: new List<Pallet>());

        mockFactory.Setup(behaviour => behaviour.Get(-1))
            .Returns(value: new List<Pallet>());

        return mockFactory;
    }
}
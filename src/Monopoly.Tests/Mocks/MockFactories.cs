namespace Monopoly.Tests.Mocks;

public static class MockFactories
{
    public static Mock<IBoxFactory> GetIBoxFactory()
    {
        Mock<IBoxFactory> mockFactory = new();

        mockFactory.Setup(behaviour => behaviour.Create(It.IsAny<Pallet>()))
            .Returns(value: new());

        return mockFactory;
    }

    public static Mock<IPalletFactory> GetIPalletFactory()
    {
        Mock<IPalletFactory> mockFactory = new();

        mockFactory.Setup(behaviour => behaviour.Create())
            .Returns(value: new());

        return mockFactory;
    }
}
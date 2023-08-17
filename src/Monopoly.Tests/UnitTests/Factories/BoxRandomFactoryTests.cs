namespace Monopoly.Tests.UnitTests.Factories;

public sealed class BoxRandomFactoryTests
{
    [Theory]
    [InlineData(10, 10, 10, 1)]
    [InlineData(10, 10, 10, 10)]
    [InlineData(2, 4, 6, 10)]
    public void Create(int height, int width, int depth, int boxCount)
    {
        // Arrange
        Pallet pallet = new()
        {
            Height = height,
            Width = width,
            Depth = depth
        };

        var factory = new BoxRandomFactory();

        // Act
        var boxes = new Box[boxCount];

        for (int i = 0; i < boxCount; i++)
        {
            boxes[i] = factory.Create(pallet);
        }

        // Assert
        Assert.True(boxes.All(box => box != null));

        Assert.DoesNotContain(boxes, box => box.Width > pallet.Width);

        Assert.DoesNotContain(boxes, box => box.Depth > pallet.Depth);
    }
}
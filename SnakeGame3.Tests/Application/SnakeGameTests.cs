using SnakeGame3.Application.Game;
using SnakeGame3.Domain.Enums;

namespace SnakeGame3.Tests.Application;
public class SnakeGameTests
{
    private readonly SnakeGame _sut;

    public SnakeGameTests()
    {
        _sut = new SnakeGame();
    }

    [Fact]
    public void IsGameOver_Works_AsExpected()
    {
        // Arrange and Act

        Assert.Throws<NotImplementedException>(() => _sut.IsGameOver());
    }

    [Fact]
    public void Move_Works_AsExpected()
    {
        // Arrange and Act

        Assert.Throws<NotImplementedException>(() => _sut.Move(Direction.UP));
    }
}

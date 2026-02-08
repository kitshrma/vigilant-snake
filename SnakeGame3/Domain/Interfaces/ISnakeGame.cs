using SnakeGame3.Domain.Enums;

namespace SnakeGame3.Domain.Interfaces;
public interface ISnakeGame
{
    public int GetScore();
    public void Move(Direction direction);
    public bool IsGameOver();
}

namespace SnakeGame3.Domain.Entities;
public record struct Board
{
    public int Height { get; }
    public int Width { get; }

    public Board(int height, int width)
    {
        Height = height;
        Width = width;
    }
}

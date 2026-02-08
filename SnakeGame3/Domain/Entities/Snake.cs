using SnakeGame3.Domain.Enums;

namespace SnakeGame3.Domain.Entities;
public class Snake
{
    public LinkedList<Position> Body { get; set; }
    public HashSet<Position> OccupiedCells { get; set; }
    public Direction CurrentDirection { get; set; }

    public Snake()
    {
        Body = new LinkedList<Position>();
        OccupiedCells = new HashSet<Position>();
        CurrentDirection = Direction.RIGHT;
    }
}

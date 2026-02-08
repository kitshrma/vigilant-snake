using SnakeGame3.Domain.Entities;
using SnakeGame3.Domain.Enums;
using SnakeGame3.Domain.Interfaces;

namespace SnakeGame3.Application.Game;
public class ConsoleGame : ISnakeGame
{
    private Snake Snake;
    private Board Board;
    private int Score;
    private Position CurrentFood;

    public ConsoleGame(int width = 16, int height = 32)
    {
        Snake = new Snake();
        Board = new Board(height, width);
    }
    public int GetScore()
    {
        return Score;
    }

    public bool IsGameOver()
    {
        return Score < 0;
    }

    public void Move(Direction direction)
    {
        Position next;

        switch(direction)
        {
            case Direction.UP:
                if (Snake.CurrentDirection != Direction.UP)
                    next = new Position(Snake.Body.First.Value.X, Snake.Body.First.Value.Y - 1);
                break;

        }

        // get new head
        // check bounds
        // check if new head is current food - yes add to score, else remove tail
        // check if new head is occupied


    }

    public void Initialize()
    {
        CreateBoundry();
        PlaceSnake();
        SpawnFood();

    }

    private void SpawnFood()
    {
        var random = new Random();
        Position food = new Position(random.Next(0, Board.Width -1), random.Next(0, Board.Height -1));

        while(Snake.OccupiedCells.Contains(food))
        {
            food = new Position(random.Next(0, Board.Width - 1), random.Next(0, Board.Height - 1));
        }

        CurrentFood = food;

    }

    private void PlaceSnake()
    {
        var head = new Position(Board.Width / 2, Board.Height / 2);
        var middle = new Position(head.X - 1, head.Y);
        var tail = new Position(head.X - 2, head.Y);

        Snake.Body.AddFirst(head);
        Snake.Body.AddLast(middle);
        Snake.Body.AddLast(tail);

        Snake.OccupiedCells.Add(head);
        Snake.OccupiedCells.Add(middle);
        Snake.OccupiedCells.Add(tail);
    }

    public void CreateBoundry()
    {
        // due to 1:2 aspect ratio make width twice of height
        // draw boundry
        int width = Board.Width + 2;
        int height = Board.Height + 1;

        // draw top
        Console.SetCursorPosition(0, 0);

        for(int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("*");
        }

        for(int i = 1; i < height - 1; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write("*");
            Console.SetCursorPosition(i, width - 1);
            Console.Write("*");
        }

        for (int i = 0; i < width; i++)
        {
            Console.SetCursorPosition(i, height - 1);
            Console.Write("*");
        }
    }
}

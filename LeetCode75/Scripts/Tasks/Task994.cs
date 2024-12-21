namespace LeetCode75.Scripts.Tasks;

public class Task994
{
    private enum Directions
    {
        Up,
        Down,
        Left,
        Right
    }

    private int _height;
    private int _width;

    private readonly Dictionary<Directions, Func<int, int, (int row, int column)>> _directions = new()
    {
        { Directions.Up, (row, column) => (row - 1, column) },
        { Directions.Down, (row, column) => (row + 1, column) },
        { Directions.Left, (row, column) => (row, column - 1) },
        { Directions.Right, (row, column) => (row, column + 1) }
    };

    public Task994()
    {
        int[][] grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];
        Console.WriteLine(OrangesRotting(grid));
    }

    public int OrangesRotting(int[][] grid)
    {
        _width = grid.Length;
        _height = grid.First().Length;

        var visited = new HashSet<(int row, int column)>();
        var rotten = new Queue<(int row, int column, int minute)>();
        var minutes = 0;

        var freshCount = CountOranges(grid, rotten, freshCount: 0);

        while (rotten.Count > 0)
        {
            var orange = rotten.Dequeue();
            minutes = orange.minute;

            foreach (var direction in Enum.GetValues<Directions>())
            {
                if (!GetNeighbourSecond(orange.row, orange.column, direction, out var position)) continue;

                if (!visited.Add((position.row, position.column)))
                {
                    continue;
                }

                var newOrange = grid[position.row][position.column];
                if (newOrange != 1)
                {
                    continue;
                }

                rotten.Enqueue((position.row, position.column, minutes + 1));
                freshCount--;
            }
        }

        return freshCount > 0 ? -1 : minutes;
    }

    private int CountOranges(int[][] grid, Queue<(int, int, int)> rotten, int freshCount)
    {
        for (var i = 0; i < _width; i++)
        {
            for (var j = 0; j < _height; j++)
            {
                switch (grid[i][j])
                {
                    case 2:
                        rotten.Enqueue((i, j, 0));
                        break;
                    case 1:
                        freshCount++;
                        break;
                }
            }
        }

        return freshCount;
    }

    private bool GetNeighbour(int row, int column, Directions direction, out (int row, int column) position)
    {
        switch (direction)
        {
            case Directions.Up:
                row--;
                break;
            case Directions.Down:
                row++;
                break;
            case Directions.Left:
                column--;
                break;
            case Directions.Right:
                column++;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }

        position = (row, column);

        return row >= 0 && row < _width && column >= 0 && column < _height;
    }

    // Another implementation using Dictionary
    private bool GetNeighbourSecond(int row, int column, Directions direction, out (int row, int column) position)
    {
        if (!_directions.TryGetValue(direction, out Func<int, int, (int, int)>? value))
        {
            throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }

        position = value(row, column);
        return position.row >= 0 && position.row < _width && position.column >= 0 && position.column < _height;
    }
}
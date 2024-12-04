namespace LeetCode75.Scripts;

public class Task2352
{
    private Dictionary<int, string> _rows = new();
    private Dictionary<int,string> _columns = new();
    public Task2352()
    {
        int[][] grid = [[3,2,1],[1,7,6],[2,7,7]];
        int[][] grid2 = [[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]];
        Console.WriteLine(EqualPairs(grid2));
    }

    public int EqualPairs(int[][] grid)
    {
        var result = 0;
        var matrixLength = grid.Length;

        for (var i = 0; i < matrixLength; i++)
        {
            _rows.TryAdd(i, "");
            for (int j = 0; j < matrixLength; j++)
            {
                _columns.TryAdd(j, "");
                _rows[i] += $"*{grid[i][j]}";
                _columns[j] += $"*{grid[i][j]}";
            }
        }

        var rows = _rows.Select(x => x.Value).ToList();
        var columns = _columns.Select(x => x.Value).ToList();

        foreach (var row in rows)
        {
            foreach (var column in columns)
            {
                if (column.Equals(row))
                {
                    result++;
                }
            }
        }

        
        return result;
    }
    
}
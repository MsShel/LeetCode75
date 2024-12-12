namespace LeetCode75.Scripts.Tasks;

public class Task118
{
    public Task118()
    {
        var generate = Generate(5);
        foreach (var list in generate)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
        
    }

    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>{new List<int>{1}};
        var row = 1;
        var triangleNumbers = new Queue<(int value, int level)>();
        triangleNumbers.Enqueue((1, row - 1));
        int left, right = 0;

        while (row < numRows)
        {
            left = right;
            var parent = triangleNumbers.Peek();
            right = parent.level > row ? 0 : parent.value;

            if (result.Count < row + 1)
            {
                 result.Add(new List<int>());
            }

            result[row].Add(left + right);
            triangleNumbers.Enqueue((left + right, row + 1));
            
            if ( parent.level > row)
            {
                row = parent.level;
            }
            else
            {
                 triangleNumbers.Dequeue();
            }
        }

        return result;
    }
}
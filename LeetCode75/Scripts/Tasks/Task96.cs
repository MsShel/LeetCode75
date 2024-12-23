namespace LeetCode75.Scripts.Tasks;

public class Task96
{
    private Dictionary<int, int> _calculated = new();

    public Task96()
    {
        Console.WriteLine(NumTrees(5));
    }

    public int NumTrees(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        if (_calculated.ContainsKey(n))
        {
            return _calculated[n];
        }

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            result += NumTrees(n - 1 - i) * NumTrees(i);
        }

        _calculated[n] = result;

        return result;
    }
}
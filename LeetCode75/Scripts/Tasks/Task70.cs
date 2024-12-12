namespace LeetCode75.Scripts.Tasks;

public class Task70
{
    private Dictionary<int, int> _list = new() { { 0, 1 } };

    public Task70()
    {
        Console.WriteLine(ClimbStairs(44));
        
    }

    public int ClimbStairs(int n)
    {
        if (_list.TryGetValue(n, out var stairs))
        { 
            return stairs;
        }

        if(n < 0)
        {
            return 0;
        }

        _list[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }
}
namespace LeetCode75.Scripts.Tasks;

public class Task746
{
    public Task746()
    {
        int[] cost = [10, 15, 20];
        int[] cost2 = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];
        Console.WriteLine(MinCostClimbingStairs(cost2));
    }

    private int MinCostClimbingStairs(int[] cost)
    {
        switch (cost.Length)
        {
            case 1:
                return cost.First();
            case 0:
                return 0;
        }

        var first = cost[0];
        var second = cost[1];

        for (var index = 2; index < cost.Length; index++)
        {
            var current = Math.Min(first, second) + cost[index];
            first = second;
            second = current;
        }

        return Math.Min(first, second);
    }

    #region Recursion solution

    private Dictionary<int, int> _costPerStep = new();
    private int[] _stairs;

    public int MinCostClimbingStairsRecursion(int[] cost)
    {
        _stairs = cost;
        var firstStep = ClimbStairs(0);
        var second = ClimbStairs(1);

        return Math.Min(firstStep, second);
    }

    private int ClimbStairs(int index)
    {
        if (_costPerStep.TryGetValue(index, out var stairs))
        {
            return stairs;
        }

        if (_stairs.Length - index < 3)
        {
            _costPerStep[index] = _stairs[index];
            return _costPerStep[index];
        }

        var min = Math.Min(ClimbStairs(index + 1), ClimbStairs(index + 2));
        var res = min + _stairs[index];
        _costPerStep[index] = res;

        return res;
    }

    #endregion
}
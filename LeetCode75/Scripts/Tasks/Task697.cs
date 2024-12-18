namespace LeetCode75.Scripts.Tasks;

public class Task697
{
    public Task697()
    {
        int[] nums = [1, 2, 2, 3, 1];
        int[] nums2 = [1, 2, 2, 3, 1, 4, 2];
        int[] nums3 = [2, 1];
        Console.WriteLine(FindShortestSubArray(nums2));
    }

    public int FindShortestSubArray(int[] nums)
    {
        var degree = new Dictionary<int, int>();
        foreach (var number in nums)
        {
            degree.TryAdd(number, 0);
            degree[number]++;
        }

        var maxVal = degree.Values.Max();
        var maxKeys = degree.Where(kv => kv.Value == maxVal).Select(kv => kv.Key).ToList();
        var positions = new Dictionary<int, (int first, int last)>();

        for (var i = 0; i < nums.Length; i++)
        {
            var item = nums[i];
            if (!maxKeys.Contains(item)) continue;
            if (positions.TryGetValue(item, out (int first, int last) value))
            {
                var valueTuple = value;
                valueTuple.last = i;
                positions[item] = valueTuple;
            }
            else
            {
                var valueTuple = (i, 0);
                positions[item] = valueTuple;
            }
        }

        var res = positions.Select(x => Math.Abs(x.Value.last - x.Value.first) + 1).Min();

        return res;
    }
}
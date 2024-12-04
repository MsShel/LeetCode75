namespace LeetCode75.Scripts;

public class Task643
{
    public Task643()
    {
        int[] nums = [1, 12, -5, -6, 50, 3];
        var k = 4;
        Console.WriteLine(FindMaxAverage(nums, k));
    }
    public double FindMaxAverage(int[] nums, int k)
    {
        double maxSum = nums.Take(k).Sum();
        var current = maxSum;

        for (var i = k; i < nums.Length; i++)
        {
            current = current - nums[i - k] + nums[i];
            maxSum = double.Max(maxSum, current);
        }

        return maxSum / k;
    }
}
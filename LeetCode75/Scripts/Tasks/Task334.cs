namespace LeetCode75.Scripts;

public class Task334
{
    public Task334()
    {
        int[] nums = [1, 2, 3, 4, 5];
        int[] nums2 = [7, 2, 1, 0, 7];
        Console.WriteLine(IncreasingTriplet(nums2));
    }

    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }

        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (var num in nums)
        {
            if (num <= first)
            {
                first = num;
            }
            else if (num <= second)
            {
                second = num;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}
namespace LeetCode75.Scripts.Tasks;

public class Task53
{
    public Task53()
    {
        int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
        int[] nums2 = [5,4,-1,7,8];
        Console.WriteLine(MaxSubArray(nums2));
    }

    public int MaxSubArray(int[] nums)
    {
        switch (nums.Length)
        {
            case < 1:
                throw new ArgumentOutOfRangeException(nameof(nums), "Array have no elements." );
            case 1:
                return nums.First();
        }

        var currentSum = nums.First();
        var maxSum = currentSum;

        for (var index = 1; index < nums.Length; index++)
        {
            var element = nums[index];
            currentSum = Math.Max(element, currentSum + element);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
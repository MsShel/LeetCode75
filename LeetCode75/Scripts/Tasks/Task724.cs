

namespace LeetCode75.Scripts;

public class Task724
{
    public void FindPivotIndex()
    {
        int[] testExample = [1, 7, 3, 6, 5, 6];
        var result = PivotIndex(testExample);
        Console.WriteLine(result);
    }

    private int PivotIndex(int[] nums)
    {
        if (nums.Length < 1)
        {
            return -1;
        }

        var leftSum = 0;
        var rightSum = nums.Sum();

        if (leftSum == rightSum - nums.First())
        {
            return 0;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            leftSum += nums[i - 1];
            rightSum -= nums[i - 1];

            if (leftSum == rightSum - nums[i])
            {
                return i;
            }
        }
        
        return -1;
    }
}
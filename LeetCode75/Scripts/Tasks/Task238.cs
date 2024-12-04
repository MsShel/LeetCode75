namespace LeetCode75.Scripts;

public class Task238
{
    public Task238()
    {
        int[] nums = [1, 2, 3, 4];
        int[] nums2 = [];
        var result = ProductExceptSelf(nums);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public int[] ProductExceptSelf(int[] nums)
    {
        var numsLength = nums.Length;

        if (numsLength < 1)
        {
            return [];
        }

        var result = new int[numsLength];
        result[0] = nums[0];

        for (var i = 1; i < numsLength - 1; i++)
        {
            result[i] = nums[i] * result[i - 1];
        }

        result[^1] = result[^2];
        var product = nums[^1];

        for (var i = numsLength - 2; i > 0; i--)
        {
            result[i] = result[i - 1] * product;
            product *= nums[i];
        }

        result[0] = product;

        return result;
    }
}
namespace LeetCode75.Scripts;

public class Task1004
{
    public Task1004()
    {
        int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
        int[] nums2 = [0, 0, 1, 1, 1, 0, 0];
        var k = 2;
        var k2 = 0;
        Console.WriteLine(LongestOnes(nums, k));
    }

    public int LongestOnes(int[] nums, int k)
    {
        var freeZeroes = k;
        var max = 0;
        var left = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                freeZeroes--;
            }

            while (freeZeroes < 0)
            {
                if (nums[left] == 0)
                {
                    freeZeroes++;
                }

                left++;
            }

            max = Math.Max(i - left + 1, max);
        }

        return max;
    }
}
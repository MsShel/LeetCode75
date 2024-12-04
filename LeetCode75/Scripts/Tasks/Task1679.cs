namespace LeetCode75.Scripts;

public class Task1679
{
    private Dictionary<int, int> _ints = new();
    public Task1679()
    {
        var result = MaxOperations1([3,1,3,4,3], 6);
        Console.WriteLine(result);
    }

    public int MaxOperations1(int[] nums, int k)
    {
        Array.Sort(nums);
        var result = 0;
        var left = 0; 
        var right = nums.Length - 1;

        while (right > left)
        {
            var sum = nums[left] + nums[right];

            if (sum.Equals(k))
            {
                result++;
                left++;
                right--;
            }
            else if (sum > k)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return result;
    }

    
}
namespace LeetCode75.Scripts;

public class Task189
{
    public Task189()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7];
        var k = 3;
        Rotate(nums, k);
    }

    public void Rotate(int[] nums, int k)
    {
        var n = nums.Length;
        k %= n;
        var res = new int [n];

        for (var i = 0; i < n; i++)
        {
            res[(i + k) % n] = nums[i];
        }

        for (var i = 0; i < n; i++)
        {
            nums[i] = res[i];
        }
    }
}
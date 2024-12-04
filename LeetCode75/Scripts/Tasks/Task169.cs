namespace LeetCode75.Scripts.Tasks;

public class Task169
{
    public Task169()
    {
        int[] nums = [3, 2, 3];
        Console.WriteLine(MajorityElement(nums));
    }

    public int MajorityElement(int[] nums)
    {
        var count = 0;
        var candidate = 0;

        foreach (var number in nums)
        {
            if (count == 0)
            {
                candidate = number;
            }

            count = candidate == number ? count + 1 : count - 1;
        }
        
        return candidate;
    }
}
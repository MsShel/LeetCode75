namespace LeetCode75.Scripts
{
    public class Task283
    {
        public Task283()
        {
            int[] nums = [0, 1, 0, 3, 12];
            MoveZeroes(nums);
        }

        public void MoveZeroes(int[] nums)
        {
            if (nums.Length < 2)
            {
                return;
            }

            var left = 0;
            var right = 1;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    right++;
                    if (nums[left] != 0)
                    {
                        left++;
                    }

                    continue;
                }

                if (nums[left] == 0)
                {
                    nums[left] ^= nums[right];
                    nums[right] ^= nums[left];
                    nums[left] ^= nums[right];
                }

                left++;
                right++;
            }

            nums.ToList().ForEach(Console.WriteLine);
        }
    }
}
namespace LeetCode75.Scripts;

public class Task4
{
    public Task4()
    {
        int[] nums1 = [1, 3];
        int[] nums2 = [2, 4];
        Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            (nums1, nums2) = (nums2, nums1);
        }

        var n = nums1.Length;
        var m = nums2.Length;
        var left = 0;
        var right = n;

        while (left <= right)
        {
            int currentX = (left + right) / 2;
            int currentY = (n + m + 1) / 2 - currentX;

            var maxX = currentX == 0 ? int.MinValue : nums1[currentX - 1];
            var maxY = currentY == 0 ? int.MinValue : nums2[currentY - 1];

            var minX = currentX == n ? int.MaxValue : nums1[currentX];
            var minY = currentY == m ? int.MaxValue : nums2[currentY];

            if (maxX <= minY && minX >= maxY)
            {
                if (((n + m) & 1) != 0) return Math.Max(maxX, maxY);
                var result = (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                return result;

            }

            if (maxX > minY)
            {
                right = currentX - 1;
            }
            else
            {
                left = currentX + 1;    
            }
        }


        throw new ArgumentException("Arrays are not valid.");
    }
}
namespace LeetCode75.Scripts;

public class Task88
{
    public Task88()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        var m = 3;
        int[] nums2 = [2, 5, 6];
        var n = 3;
        Merge(nums1, m, nums2, n);
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        m--;
        var i = m + n;
        n--;

        while (n >= 0)
        {
            if (m >= 0 && nums1[m] > nums2[n])
            {
                nums1[i] = nums1[m];
                m--;
            }
            else
            {
                nums1[i] = nums2[n];
                n--;
            }

            i--;
        }
    }
}
namespace LeetCode75.Scripts;

public class Task215
{

    // For future: try to use quick search

    public Task215()
    {
        int[] nums = [3, 2, 1, 5, 6, 4];
        int[] nums2 = [3,2,3,1,2,4,5,5,6];
        var k = 2;
        var k2 = 4;
        Console.WriteLine(FindKthLargest(nums, k));
    }

    public int FindKthLargest(int[] nums, int k)
    {
        if (nums.Length < 1)
        {
            return 0;
        }

        var maxElementsQueue = new PriorityQueue<int, int>();

        foreach (var element in nums)
        {
            maxElementsQueue.Enqueue(element, element);

            if (maxElementsQueue.Count > k)
            {
                maxElementsQueue.Dequeue();
            }
        }

        return maxElementsQueue.Dequeue();
    }
}
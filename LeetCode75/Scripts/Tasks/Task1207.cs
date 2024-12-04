namespace LeetCode75.Scripts;

public class Task1207
{
    public Task1207()
    {
        int[] arr = [1, 2, 2, 1, 1, 3];
        Console.WriteLine(UniqueOccurrences(arr));
    }

    public bool UniqueOccurrences(int[] arr)
    {
        var occurrencesFrequency = new Dictionary<int, int>();
        var uniqueElementsCount = 0;

        foreach (var element in arr)
        {
            if (!occurrencesFrequency.TryGetValue(element, out _))
            {
                occurrencesFrequency[element] = 0;
                uniqueElementsCount++;
            }

            occurrencesFrequency[element]++;
        }

        var set = occurrencesFrequency.Values.ToHashSet().Count;
        return set == uniqueElementsCount;
    }
}
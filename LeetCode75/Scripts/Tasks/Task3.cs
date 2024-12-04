namespace LeetCode75.Scripts;

public class Task3
{
    public Task3()
    {
        var s = "abcabcbb";
        Console.WriteLine(LengthOfLongestSubstring(s));
    }

    public int LengthOfLongestSubstring(string s)
    {
        var count = 0;
        var sequence = "";
        foreach (var character in s)
        {
            while (sequence.Contains(character))
            {
                sequence = sequence.Remove(0, 1);
            }

            sequence += character;
            count = Math.Max(count, sequence.Length);
        }

        return count;
    }
}
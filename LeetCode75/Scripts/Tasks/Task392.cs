namespace LeetCode75.Scripts;

public class Task392
{
    public Task392()
    {
        var s = "abc";
        var t = "ahbgdc";
        s = "axc";
        t = "ahbgdc";
        Console.WriteLine(IsSubsequence(s, t));
    }
    public bool IsSubsequence(string s, string t)
    {
        var sLength = s.Length;
        var tLength = t.Length;

        if (sLength > tLength)
        {
            return false;
        }
        var sPointer = 0;
        var tPointer = 0;

        while (sPointer < sLength && tPointer < tLength)
        {
            if (s[sPointer] == t[tPointer])
            {
                sPointer++;
            }

            tPointer++;
        }

        return sPointer >= sLength;
    }
}
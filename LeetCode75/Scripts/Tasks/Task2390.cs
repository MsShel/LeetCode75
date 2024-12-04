namespace LeetCode75.Scripts;

public class Task2390
{
    public Task2390()
    {
        var s1 = "leet**cod*e";
        var s2 = "abb*cdfg*****x*";
        Console.WriteLine(RemoveStars(s2));
    }

    public string RemoveStars(string s)
    {
        var length = s.Length;
        var resultStack = new Stack<char>();
        var result = "";

        resultStack.Push(s[0]);

        for (var i = 1; i < length; i++)
        {
            if (s[i].Equals('*'))
            {
                if (resultStack.Count > 0)
                {
                    resultStack.Pop();
                }
            }
            else
            {
                resultStack.Push(s[i]);
            }
        }

        return string.Concat(resultStack.Reverse());
    }
}
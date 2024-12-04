namespace LeetCode75.Scripts;

public class Task394
{
    public Task394()
    {
        var s = "3[a]2[bc]";
        var s2 = "100[leetcode]";
        Console.WriteLine(DecodeString(s2));
    }

    public string DecodeString(string s)
    {
        var result = "";
        var stack = new Stack<char>();

        foreach (var t in s)
        {
            if (t != ']')
            {
                stack.Push(t);
                continue;
            }

            var temp = "";
            while (stack.Count > 0 && stack.Peek() != '[')
            {
                temp = stack.Pop() + temp;
            }

            stack.Pop();
            var res = temp;
            var repeats = 0;
            var rank = 1;
            while (stack.Count > 0 && char.IsDigit(stack.Peek()))
            {
                repeats += + int.Parse(stack.Pop().ToString()) * rank;
                rank *= 10;
            }

            for (int j = 1; j < repeats; j++)
            {
                res += temp;
            }

            foreach (var letter in res)
            {
                stack.Push(letter);
            }
        }

        while (stack.Count > 0)
        {
            result = stack.Pop() + result;
        }

        return result;
    }
}
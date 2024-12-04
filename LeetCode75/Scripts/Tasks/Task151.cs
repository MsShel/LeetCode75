namespace LeetCode75.Scripts;

public class Task151
{
    public Task151()
    {
        var s = "the sky is blue";
        var s2 = "  hello world  ";
        Console.WriteLine(ReverseWordsV2(s));
    }

    public string ReverseWords(string s)
    {
        var wordArray = new List<string>();
        var j = -1;

        for (var i = 0; i < s.Length - 1; i++)
        {
            if (!s[i].Equals(' '))
            {
                 j++;
                 wordArray.Add("");
            }

            while (i < s.Length && !s[i].Equals(' '))
            {
                wordArray[j] += s[i];
                i++;
            }
        }

        var res = "";

        for (var index = wordArray.Count - 1; index >= 1; index--)
        {
            var word = wordArray[index];
            res += word + " ";
        }

        res += wordArray[0];

        return res;
    }

    public string ReverseWordsV2(string s)
    {
        var wordsArray = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

        return string.Join(" ", wordsArray);
    }
}
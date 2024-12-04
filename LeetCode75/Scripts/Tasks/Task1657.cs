namespace LeetCode75.Scripts;

public class Task1657
{
    private Dictionary<Char, int> _lettersWordOne = new();
    private Dictionary<Char, int> _lettersWordTwo = new();

    public Task1657()
    {
        var word1 = "uua";
        var word2 = "xxb";

        Console.WriteLine(CloseStrings(word1, word2));
    }

    // O(nLog(n))
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        ParseWord(word1, _lettersWordOne);
        ParseWord(word2, _lettersWordTwo);

        if (_lettersWordOne.Select(x => x.Key).Any(key => !_lettersWordTwo.ContainsKey(key)))
        {
            return false;
        }

        var letterAmount1 = _lettersWordOne.Select(x => x.Value).ToList();
        var letterAmount2 = _lettersWordTwo.Select(x => x.Value).ToList();

        if (letterAmount1.Count != letterAmount2.Count)
        {
            return false;
        }

        letterAmount1.Sort();
        letterAmount2.Sort();

        return !letterAmount1.Where((t, i) => t != letterAmount2[i]).Any();
    }

    private void ParseWord(string word1, Dictionary<Char, int> charDictionary)
    {
        foreach (var letter in word1)
        {
            if (!charDictionary.TryGetValue(letter, out _))
            {
                charDictionary[letter] = 1;
            }
            else
            {
                charDictionary[letter]++;
            }
        }
    }
}
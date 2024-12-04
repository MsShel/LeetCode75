namespace LeetCode75.Scripts;

public class Task345
{
    private List<char> _vowels = new() {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

    public Task345()
    {
        var s = "Ioa";
        Console.WriteLine(ReverseVowels(s));
    }

    public string ReverseVowels(string s)
    {
        var letters = s.ToCharArray();
        var left = 0;
        var right = s.Length - 1;

        while (left <= right)
        {
            while (left <= right && !_vowels.Contains(letters[left]))
            {
                left++;
            }

            while (left <= right && !_vowels.Contains(letters[right]))
            {
                right--;
            }

            if (left <= right && _vowels.Contains(s[right]) && _vowels.Contains(s[left]))
            {
                var temp = s[left];
                letters[left] = s[right];
                letters[right] = temp;
            }

            left++;
            right--;
        }

        return new string(letters);
    }
}
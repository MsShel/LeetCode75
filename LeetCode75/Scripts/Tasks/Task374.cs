namespace LeetCode75.Scripts.Tasks;

public class Task374
{
    private int _pick;

    public Task374()
    {
        _pick = 6;
        Console.WriteLine(GuessNumber(10));
    }

    public int GuessNumber(int n)
    {
        var left = 1;
        var right = n;

        while (right >= left)
        {
            var res = (right - left) / 2 + left;
            var isRight = guess(res);

            switch (isRight)
            {
                case 1:
                    left = res + 1;
                    break;
                case -1:
                    right = res - 1;
                    break;
                case 0:
                    return res;
                
            }
        }

        return 0;
    }

    public int guess(int num)
    {
        if (num == _pick)
            return 0;
        if (num > _pick)
            return -1;
        return 1;
    }
}
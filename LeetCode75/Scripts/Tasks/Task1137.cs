namespace LeetCode75.Scripts.Tasks;

public class Task1137
{
    public Task1137()
    {
        Console.WriteLine(Tribonacci(25));
    }

    public int Tribonacci(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1 or 2:
                return 1;
        }

        var first = 0;
        var second = 1;
        var third = 1;
        var current = first;

        var i = 3;

        while (i <= n)
        {
            i++;
            current = first + second + third;

            first = second;
            second = third;
            third = current;
        }

        return current;
    }
}
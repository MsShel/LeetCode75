namespace LeetCode75.Scripts.Tasks;

public class Task509
{
    public Task509()
    {
        Console.WriteLine(Fib(4));
    }

    public int Fib(int n)
    {
        if (n is 0 or 1)
        {
            return n;
        }

        var result = 0;
        int current = 1, previous = 0;
        var index = 2;

        while (index <= n)
        {
            result = current + previous;
            previous = current;
            current = result;
            index++;
        }
        
        return result;
    }
}
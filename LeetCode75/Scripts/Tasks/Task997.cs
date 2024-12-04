namespace LeetCode75.Scripts;

public class Task997
{
    public Task997()
    {
        var n = 3;
        int[][] trust = [[1, 3], [2, 3]];
        Console.WriteLine(FindJudge(n, trust));
    }

    public int FindJudge(int n, int[][] trust)
    {
        var trustTo = new int[n + 1];
        var trustWho= new int[n + 1];

        foreach (var pair in trust)
        {
            trustWho[pair[0]]++;
            trustTo[pair[1]]++;
        }

        for (var i = 1; i <= n; i++)
        {
            if (trustWho[i] == 0 && trustTo[i] == n - 1)
            {
                return i;
            }
        }

        return -1;
    }
}
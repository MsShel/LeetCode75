namespace LeetCode75.Scripts;

public class Task1791
{
    public Task1791()
    {
        int[][] edges = [[1, 2], [2, 3], [4, 2]];
        Console.WriteLine(FindCenter(edges));
    }

    private int FindCenter(int[][] edges)
    {
        var result = 0;
        var nodeSet = new HashSet<int>();

        foreach (var edge in edges)
        {
            foreach (var node in edge)
            {
                if (!nodeSet.Add(node))
                {
                    return node;
                }
            }
        }

        // Alternate:
        // foreach (var node in edges.SelectMany(edge => edge))
        // {
        //     if (!nodeSet.Add(node))
        //     {
        //         return node;
        //     }
        // }


        return result;
    }
}
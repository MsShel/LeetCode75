namespace LeetCode75.Scripts;

public class Task1971
{

    public Task1971()
    {
        var n = 1;
        int[][] edges = [];
        var source = 0;
        var destination = 0;

        Console.WriteLine(ValidPath(n, edges, source, destination));
    }

    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
       

        if (edges.Length < 1)
        {
            return source == destination;
        }

        if (source == destination)
        {
            return true;
        }

        var graph = GraphBuilder.BuildAdjacencyList(n, edges);
        var visit = new HashSet<int>();
        var nodesQueue = new Queue<int>();

        nodesQueue.Enqueue(source);
        while (nodesQueue.Count > 0)
        {
            var node = nodesQueue.Dequeue();
            if (node == destination)
            {
                return true;
            }

            foreach (var neighbour in graph[node])
            {
                if (!visit.Add(neighbour))
                {
                    continue;
                }

                if (neighbour == destination)
                {
                    return true;
                }

                
                nodesQueue.Enqueue(neighbour);
            }
        }

        return false;
    }
}
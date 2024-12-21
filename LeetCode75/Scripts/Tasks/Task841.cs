namespace LeetCode75.Scripts.Tasks;

public class Task841
{
    public Task841()
    {
        IList<IList<int>> rooms = [[1], [2], [3], []];
        IList<IList<int>> rooms2 = [[1,3],[3,0,1],[2],[0]];
        Console.WriteLine(CanVisitAllRooms(rooms2));
    }

    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visited = new HashSet<int>();
        var neighbours = new Dictionary<int, List<int>>();
        var path = new Queue<int>();

        for (var index = 0; index < rooms.Count; index++)
        {
            neighbours[index] = new(rooms[index]);
        }

        path.Enqueue(neighbours.First().Key);
        visited.Add(neighbours.First().Key);

        while (path.Count > 0)
        {
            var room = path.Dequeue();

            if (!neighbours.TryGetValue(room, out var neighbour)) continue;
            foreach (var key in neighbour)
            {
                if (!visited.Add(key))
                {
                    continue;
                }
                path.Enqueue(key);
            }
        }

        return visited.Count == rooms.Count;
    }
}
namespace LeetCode75.Scripts;

public static class GraphBuilder
{
    public static Dictionary<int, List<int>> BuildAdjacencyList(int n, int[][] edges)
    {
        // Словарь для списка смежности
        var graph = new Dictionary<int, List<int>>();

        // Инициализация списка смежности для каждой вершины
        for (var i = 0; i < n; i++) graph[i] = new List<int>();

        // Перебор рёбер и добавление в список смежности
        foreach (var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];

            // Добавляем ребра в обе стороны, так как граф неориентированный
            graph[u].Add(v);
            graph[v].Add(u);
        }

        return graph;
    }
}
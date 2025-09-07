namespace Programming.Patterns.Graph.FindIfPathExists;

using System;
using System.Collections.Generic;

public class Solution
{
    public bool validPath(int n, int[][] edges, int start, int end)
    {
        Dictionary<int, List<int>> adjacency = new();
        for (var i = 0; i < edges.Length; i++)
        {
            if (!adjacency.ContainsKey(edges[i][0]))
                adjacency.Add(edges[i][0], [edges[i][1]]);
            else
                adjacency[edges[i][0]].Add(edges[i][1]);

            if (!adjacency.ContainsKey(edges[i][1]))
                adjacency.Add(edges[i][1], [edges[i][0]]);
            else
                adjacency[edges[i][1]].Add(edges[i][0]);
        }


        bool[] visited = new bool[n];
        Stack<int> stack = new(n);
        stack.Push(start);

        while (stack.Count > 0)
        {
            var v = stack.Pop();
            if (visited[v])
            {
                continue;
            }

            visited[v] = true;

            if (v == end) return true;

            var vertices = adjacency[v];
            foreach (var vertex in vertices)
            {
                if (visited[vertex]) continue;

                stack.Push(vertex);
            }
        }

        return false;
    }
}

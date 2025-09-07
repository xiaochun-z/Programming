namespace Programming.Patterns.Graph.FindIfPathExists;

using System;
using System.Collections.Generic;

public class Solution
{
    public bool validPath(int n, int[][] edges, int start, int end)
    {
        // Input validation
        // if (n <= 0 || start < 0 || start >= n || end < 0 || end >= n)
        //     return false;
        if (start == end)
            return true;

        // Initialize adjacency list for all vertices
        var adjacency = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++)
        {
            adjacency[i] = new List<int>();
        }

        // Build adjacency list
        foreach (var edge in edges)
        {
            if (edge.Length != 2 /*|| edge[0] < 0 || edge[0] >= n || edge[1] < 0 || edge[1] >= n*/)
                return false;
            adjacency[edge[0]].Add(edge[1]);
            adjacency[edge[1]].Add(edge[0]);
        }

        // DFS
        var visited = new bool[n];
        var stack = new Stack<int>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            var currentVertex = stack.Pop();
            if (visited[currentVertex])
                continue;

            visited[currentVertex] = true;
            if (currentVertex == end)
                return true;

            foreach (var neighbor in adjacency[currentVertex])
            {
                if (!visited[neighbor])
                    stack.Push(neighbor);
            }
        }

        return false;
    }
}

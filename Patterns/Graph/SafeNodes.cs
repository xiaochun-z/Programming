namespace Programming.Patterns.Graph.SafeNodes;
/*
Find Eventual Safe States (medium)
Problem Statement

You are given a directed graph with n nodes, labeled from 0 to n-1. This graph is described by a 2D integer array graph, where graph[i] is an array of nodes adjacent to node i, indicating there is a directed edge from node i to each of the nodes in graph[i].

A node is called a terminal node if it has no outgoing edges. A node is considered safe if every path starting from that node leads to a terminal node (or another safe node).

Return an array of all safe nodes in ascending order.
Examples

Example 1:

    Input: graph = [[1,2],[2,3],[2],[],[5],[6],[]]

    Expected Output: [3,4,5,6]
    Explanation:
        Node 3 is a terminal node.
        Node 4 leads to node 5, which is a safe node.
        Node 5 leads to node 6, which is a terminal node.
        Node 6 is a terminal node.

Example 2:

    Input: graph = [[1,2],[2,3],[5],[0],[],[],[4]]

    Expected Output: [2,4,5,6]
    Explanation:
        Node 2 leads to node 5, which is a terminal node.
        Node 4 is a terminal node.
        Node 5 is a terminal node.
        Node 6 leads to node 4, which is a terminal node.

Example 3:

    Input: graph = [[1,2,3],[2,3],[3],[],[0,1,2]]

    Expected Output: [0,1,2,3,4]
    Explanation:
        Node 3 is a terminal node.
        Node 2 leads to node 3, which is a terminal node.
        Node 1 leads to node 2, which is a safe node, and node 3, which is a terminal node.
        Similarly, all node leads to either a terminal or a safe node.

Constraints:

    n == graph.length
    1 <= n <= 104
    0 <= graph[i].length <= n
    0 <= graph[i][j] <= n - 1
    graph[i] is sorted in a strictly increasing order.
    The graph may contain self-loops.
    The number of edges in the graph will be in the range [1, 4 * 104].

*/
using System;
using System.Collections.Generic;

public class Solution
{
    public List<int> eventualSafeNodes(int[][] graph)
    {
        List<int> result = new List<int>();
        int n = graph.Length;
        int[] visited = new int[n]; // 0: unvisited, 1: visiting, -1: safe
        for (var i = 0; i < n; i++)
        {
            if (Dfs(i, graph, visited))
            {
                result.Add(i);
            }
        }
        return result;
    }

    private bool Dfs(int i, int[][] graph, int[] visited)
    {
        if (visited[i] == -1) return true;
        if (visited[i] == 1) return false;
        visited[i] = 1;
        foreach (var neighbor in graph[i])
        {
            if (!Dfs(neighbor, graph, visited))
            {
                return false;
            }
        }
        visited[i] = -1;
        return true;
    }
}
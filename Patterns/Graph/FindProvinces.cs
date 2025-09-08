using System.ComponentModel;

namespace Programming.Patterns.Graph.FindProvinces;

/*

Number of Provinces (medium)

Problem Statement

There are n cities. Some of them are connected in a network. If City A is directly connected to City B, and City B is directly connected to City C, city A is indirectly connected to City C.

If a group of cities are connected directly or indirectly, they form a province.

Given an n x n matrix isConnected where isConnected[i][j] = 1 if the ith city and the jth city are directly connected, and isConnected[i][j] = 0 otherwise, determine the total number of provinces.
Examples

    Example 1:
        Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]


    Expected Output: 2

    Justification: Here, city 1 and 2 form a single provenance, and city 3 is one province itself.

    Example 2:
        Input: isConnected = [1,0,0],[0,1,0],[0,0,1]]


    Expected Output: 3

    Justification: In this scenario, no cities are connected to each other, so each city forms its own province.

    Example 3:
        Input: isConnected = [[1,0,0,1],[0,1,1,0],[0,1,1,0],[1,0,0,1]]

    Expected Output: 2
    Justification: Cities 1 and 4 form a province, and cities 2 and 3 form another province, resulting in a total of 2 provinces.

Constraints:

    1 <= n <= 200
    n == isConnected.length
    n == isConnected[i].length
    isConnected[i][j] is 1 or 0.
    isConnected[i][i] == 1
    isConnected[i][j] == isConnected[j][i]

*/

public class Solution
{
    public int findProvinces(int[][] isConnected)
    {
        int n = isConnected.Length; // n cities.
        bool[] visited = new bool[n];

        int result = 0;
        for (var i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                DFS(i, isConnected, visited);
                result++;
            }
        }

        return result;
    }

    private void DFS(int city, int[][] isConnected, bool[] visited)
    {
        visited[city] = true;
        for (var i = 0; i < isConnected.Length; i++)
        {
            if (isConnected[city][i] == 1 && !visited[i])
            {
                DFS(i, isConnected, visited);
            }
        }
    }
}
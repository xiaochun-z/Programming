namespace Programming.Patterns.Island.BiggestIsland;

using System;
/*
Biggest Island (easy)

Problem Statement

Given a 2D array (i.e., a matrix) containing only 1s (land) and 0s (water), find the biggest island in it. Write a function to return the area of the biggest island. 

An island is a connected set of 1s (land) and is surrounded by either an edge or 0s (water). Each cell is considered connected to other cells horizontally or vertically (not diagonally).
*/
public class Solution
{
    public int maxAreaOfIsland(int[][] matrix)
    {
        int biggestIslandArea = 0;
        int row = matrix.Length;
        int col = matrix[0].Length;

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < col; j++)
            {
                var area = Dfs(i, j, matrix);
                biggestIslandArea = Math.Max(biggestIslandArea, area);
            }
        }
        return biggestIslandArea;
    }

    private int Dfs(int x, int y, int[][] maxtrix)
    {
        if (x < 0 || x >= maxtrix.Length || y < 0 || y >= maxtrix[0].Length)
        {
            return 0;
        }

        if (maxtrix[x][y] == 0) return 0;
        maxtrix[x][y] = 0;

        var area = 1;
        area += Dfs(x, y - 1, maxtrix);
        area += Dfs(x, y + 1, maxtrix);
        area += Dfs(x - 1, y, maxtrix);
        area += Dfs(x + 1, y, maxtrix);
        return area;
    }
}

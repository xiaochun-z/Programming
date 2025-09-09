namespace Programming.Patterns.Island.NumOfIsland;

/*
Problem Statement

Given a 2D array (i.e., a matrix) containing only 1s (land) and 0s (water), count the number of islands in it.

An island is a connected set of 1s (land) and is surrounded by either an edge or 0s (water). Each cell is 
considered connected to other cells horizontally or vertically (not diagonally).
*/
using System;

public class Solution
{
    public int countIslands(int[][] matrix)
    {
        int totalIslands = 0;
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (matrix[i][j] == 1)
                {
                    totalIslands++;
                    Dfs(i, j, matrix);
                }
            }
        }
        return totalIslands;
    }

    private void Dfs(int i, int j, int[][] matrix)
    {
        int row = matrix.Length;
        int col = matrix[0].Length;
        if (i < 0 || i >= row || j < 0 || j >= col) return;
        if (matrix[i][j] == 0) return;

        matrix[i][j] = 0;// imagine the island was swallowed by the water so it wont count again.

        Dfs(i, j - 1, matrix);
        Dfs(i, j + 1, matrix);
        Dfs(i - 1, j, matrix);
        Dfs(i + 1, j, matrix);
    }
}

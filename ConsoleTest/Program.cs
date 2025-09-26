using System;
class Solution
{
    public int solveKnapsack(int[] profits, int[] weights, int capacity)
    {
        // base checks
        if (capacity <= 0 || profits.Length == 0 || weights.Length != profits.Length)
            return 0;
        int n = profits.Length;
        int[][] dp = new int[n][];
        for (int i = 0; i < n; i++)
        {
            dp[i] = new int[capacity + 1];
        }
        // populate the capacity=0 columns, with '0' capacity we have '0' profit
        for (int i = 0; i < n; i++)
        {
            dp[i][0] = 0;
        }
        // if we have only one weight, we will take it if it is not more than the capacity
        for (int c = 0; c <= capacity; c++)
        {
            if (weights[0] <= c)
            {
                dp[0][c] = profits[0];
            }
        }
        // process all sub-arrays for all the capacities
        for (int i = 1; i < n; i++)
        {
            for (int c = 1; c <= capacity; c++)
            {
                int profit1 = 0, profit2 = 0;
                // include the item, if it is not more than the capacity
                if (weights[i] <= c)
                {
                    profit1 = profits[i] + dp[i - 1][c - weights[i]];
                }
                // exclude the item
                profit2 = dp[i - 1][c];
                // take maximum
                dp[i][c] = Math.Max(profit1, profit2);
            }
        }
        PrintSelectedElements(dp, weights, profits, capacity);
        // maximum profit will be at the bottom-right corner.
        return dp[n - 1][capacity];
    }
    private void PrintSelectedElements(int[][] dp, int[] weights, int[] profits, int capacity)
    {
        Console.Write("Selected weights:");
        int totalProfit = dp[weights.Length - 1][capacity];
        for (int i = weights.Length - 1; i > 0; i--)
        {
            if (totalProfit != dp[i - 1][capacity])
            {
                Console.Write(" " + weights[i]);
                capacity -= weights[i];
                totalProfit -= profits[i];
            }
        }
        if (totalProfit != 0)
        {
            Console.Write(" " + weights[0]);
        }
        Console.WriteLine("");
    }
    public static void Main(string[] args)
    {
        Solution ks = new Solution();
        int[] profits = { 1, 6, 10, 16 };
        int[] weights = { 1, 2, 3, 5 };
        int maxProfit = ks.solveKnapsack(profits, weights, 7);
        Console.WriteLine("Total knapsack profit ---> " + maxProfit);
        maxProfit = ks.solveKnapsack(profits, weights, 6);
        Console.WriteLine("Total knapsack profit ---> " + maxProfit);
    }
}
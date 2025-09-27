namespace Programming.Patterns.FibonacciNumbers.Dp;

/*
Problem Statement

Write a function to calculate the nth Fibonacci number.

Fibonacci numbers are a series of numbers in which each number is the sum of the two preceding numbers. First few Fibonacci numbers are: 0, 1, 1, 2, 3, 5, 8, ...

Mathematically we can define the Fibonacci numbers as:

    Fib(n) = Fib(n-1) + Fib(n-2), for n > 1

    Given that: Fib(0) = 0, and Fib(1) = 1

Constraints:

    0 <= n <= 30

*/

using System;
public class Solution
{
    public int calculateFibonacci(int n)
    {
        if (n <= 2) return n;

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        for (var i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }

    public int calculateFibonacci2(int n)
    {
        int[] dp = new int[n + 1];
        return calculateFibonacciRecursive(dp, n);
    }
    public int calculateFibonacciRecursive(int[] dp, int n)
    {
        if (n < 2)
            return n;
        if (dp[n] == 0)
            dp[n] = calculateFibonacciRecursive(dp, n - 1) + calculateFibonacciRecursive(dp, n - 2);
        return dp[n];
    }
}

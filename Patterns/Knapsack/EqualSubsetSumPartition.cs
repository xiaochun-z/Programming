namespace Programming.Patterns.Knapsack.EqualSubsetSumPartition;
/*
Equal Subset Sum Partition (medium)
Given a set of positive numbers, find if we can partition it into two subsets such that the sum of elements in both subsets is equal.

Example 1:

Input: {1, 2, 3, 4}
Output: True
Explanation: The given set can be partitioned into two subsets with equal sum: {1, 4} & {2, 3}

Example 2:

Input: {1, 1, 3, 4, 7}
Output: True
Explanation: The given set can be partitioned into two subsets with equal sum: {1, 3, 4} & {1, 7}

Example 3:

Input: {2, 3, 4, 6}
Output: False
Explanation: The given set cannot be partitioned into two subsets with equal sum.

Constraints:

    1 <= nums.length <= 200
    1 <= nums[i] <= 100

*/
using System;
using System.Runtime.CompilerServices;

public class Solution
{
    public bool canPartition(int[] num)
    {
        int sum = 0;
        foreach (int n in num)
        {
            sum += n;
        }

        if (sum % 2 == 1)
        {
            return false;
        }

        var dp = new bool?[num.Length][];
        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = new bool?[sum / 2 + 1];
        }

        return canPartition(dp, num, sum / 2, 0);
    }

    private bool canPartition(bool?[][] dp, int[] num, int sum, int currentIndex)
    {
        if (sum == 0) return true;

        if (currentIndex >= num.Length)
        {
            return false;
        }

        if (!dp[currentIndex][sum].HasValue)
        {
            if (num[currentIndex] <= sum)
            {
                if (canPartition(dp, num, sum - num[currentIndex], currentIndex + 1))
                {
                    dp[currentIndex][sum] = true;
                    return true;
                }
            }

            dp[currentIndex][sum] = canPartition(dp, num, sum, currentIndex + 1);
        }

        return dp[currentIndex][sum]!.Value;
    }
}

/*
The time complexity of the above algorithm is exponential O(2^n), 
where ‘n’ represents the total number. The space complexity is O(n), 
which will be used to store the recursion stack.
*/
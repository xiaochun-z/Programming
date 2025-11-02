namespace Programming.Patterns.Backtracking.CombinationSum;

/*
Problem statement:

Given an array of distinct positive integers candidates and a target integer target, 
return a list of all unique combinations of candidates where the chosen numbers sum to target. 
You may return the combinations in any order.
The same number may be chosen from candidates an unlimited number of times. 
Two combinations are unique if the frequency of at least one of the chosen numbers is different.

Example 1:

Input: candidates = [2, 3, 6, 7], target = 7  
Output: [[2, 2, 3], [7]]  
Explanation: The elements in these two combinations sum up to 7.

Example 2:

Input: candidates = [2, 4, 6, 8], target = 10  
Output: [[2,2,2,2,2], [2,2,2,4], [2,2,6], [2,4,4], [2,8], [4,6]]    
Explanation: The elements in these six combinations sum up to 10.

Constraints:

    1 <= candidates.length <= 30
    2 <= candidates[i] <= 40
    All elements of candidates are distinct.
    1 <= target <= 40

*/
using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public List<List<int>> combinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var res = new List<List<int>>();
        var path = new List<int>();

        BacktrackCombine(0, 0);
        return res;

        void BacktrackCombine(int start, int currentSum)
        {
            if (currentSum == target)
            {
                res.Add([.. path]);
                return;
            }
            if (currentSum > target || start >= candidates.Length)
            {
                return;
            }

            // 1) 选当前 start
            path.Add(candidates[start]);
            BacktrackCombine(start, currentSum + candidates[start]); // 可重复使用
            path.RemoveAt(path.Count - 1);

            // 2) 不选当前 start，尝试下一个
            BacktrackCombine(start + 1, currentSum);
        }
    }
}

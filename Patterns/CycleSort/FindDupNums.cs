namespace Programming.Patterns.CycleSort.FindDupNums;
/*
Solution: Find all Duplicate Numbers

Problem Statement

We are given an unsorted array containing n numbers taken from the range 1 to n. The array has some numbers appearing twice, find all these duplicate numbers using constant space.

Example 1:

Input: [3, 4, 4, 5, 5]
Output: [4, 5]

Example 2:

Input: [5, 4, 7, 2, 3, 5, 3]
Output: [3, 5]

Constraints:

    nums.length == n
    1 <= n <= 

1 <= nums[i] <= n
Each element in nums appears once or twice.
*/

using System;
using System.Collections.Generic;

public class Solution
{

    public List<int> findNumbers(int[] nums)
    {
        List<int> duplicateNumbers = [];
        var i = 0;
        while (i < nums.Length)
        {
            var j = nums[i] - 1;
            if (nums[i] != nums[j])
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
            else
            {
                i++;
            }
        }

        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                duplicateNumbers.Add(nums[i]);
            }
        }
        return duplicateNumbers;
    }
}

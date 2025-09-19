namespace Programming.Patterns.TopKElements.TopKFreqency;
/*
Top 'K' Frequent Numbers (medium)
Problem Statement

Given an unsorted array of numbers, find the top ‘K’ frequently occurring numbers in it.

Example 1:

Input: [1, 3, 5, 12, 11, 12, 11], K = 2
Output: [12, 11]
Explanation: Both '11' and '12' appeared twice.

Example 2:

Input: [5, 12, 11, 3, 11], K = 2
Output: [11, 5] or [11, 12] or [11, 3]
Explanation: Only '11' appeared twice; all other numbers appeared once.

Constraints:

    1 <= nums.length <= 105
    -105 <= nums[i] <= 105
    k is in the range [1, the number of unique elements in the array].
    It is guaranteed that the answer is unique.

*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{

    public List<int> findTopKFrequentNumbers(int[] nums, int k)
    {
        List<int> topNumbers = new List<int>();

        Dictionary<int, int> dict = [];
        foreach (int n in nums)
        {
            dict[n] = dict.GetValueOrDefault(n, 0) + 1;
        }

        SortedDictionary<int, List<int>> min_heap = [];
        foreach (var kv in dict)
        {
            if (!min_heap.ContainsKey(kv.Value)) min_heap[kv.Value] = [];

            if (min_heap.Count >= k && kv.Value > min_heap.First().Key)
            {
                min_heap.Remove(kv.Value);
            }

            min_heap[kv.Value].Add(kv.Key);
        }

        var reverse = min_heap.Reverse();
        foreach (var kv in reverse)
        {
            foreach (var n in kv.Value)
            {
                if (topNumbers.Count >= k) break;
                topNumbers.Add(n);
            }
        }

        return topNumbers;
    }
}

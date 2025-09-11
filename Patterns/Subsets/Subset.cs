namespace Programming.Patterns.Subsets.Subset;

using System;
using System.Collections.Generic;
using System.Linq;

/*

Subsets (easy)

Problem Statement

Given a set with distinct elements, find all of its distinct subsets.

Example 1:

Input: [1, 3]
Output: [], [1], [3], [1,3]

Example 2:

Input: [1, 5, 3]
Output: [], [1], [5], [3], [1,5], [1,3], [5,3], [1,5,3]

Constraints:

    1 <= nums.length <= 10
    -10 <= nums[i] <= 10
    All the numbers of nums are unique.

*/

public class Solution
{

    public List<List<int>> findSubsets(int[] nums)
    {
        List<List<int>> subsets = new List<List<int>>();
        subsets.Add([]);
        for (var i = 0; i < nums.Length; i++)
        {
            var newsets = new List<List<int>>();
            for (var j = 0; j < subsets.Count; j++)
            {
                var set = new List<int>();
                set.AddRange(subsets[j]);
                set.Add(nums[i]);
                newsets.Add(set);
            }

            subsets.AddRange(newsets);
        }
        return subsets;
    }
}

namespace Programming.Patterns.Subsets.SubsetDup;

using System;
using System.Collections.Generic;

public class Solution
{

    public List<List<int>> findSubsets(int[] nums)
    {
        List<List<int>> subsets = new List<List<int>>();
        subsets.Add([]);
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < nums.Length; i++) {
            startIndex = 0;
            // if current and the previous elements are same, create new subsets only from the 
            // subsets added in the previous step
            if (i > 0 && nums[i] == nums[i - 1])
                startIndex = endIndex + 1;
            endIndex = subsets.Count - 1;
            for (int j = startIndex; j <= endIndex; j++) {
                // create a new subset from the existing subset and add the current element to it
                List<int> set = [.. subsets[j]];
                set.Add(nums[i]);
                subsets.Add(set);
            }
        }
        return subsets;
    }
}

/*
given [1,2,2]
[]
[],[1]
[],[1],[2],[1,2]
[],[1],[2],[1,2],[2,2], [1,2,2]

*/

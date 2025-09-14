namespace Programming.Patterns.Subsets.Permutations;

using System;
using System.Collections.Generic;

/*
Permutations (medium)
Problem Statement

Given a set of distinct numbers, find all of its permutations.

Permutation is defined as the re-arranging of the elements of the set. For example, {1, 2, 3} has the following six permutations:

{1, 2, 3} {1, 3, 2} {2, 1, 3} {2, 3, 1} {3, 1, 2} {3, 2, 1}

If a set has
distinct elements it will have

permutations.

Example 1:

Input: [1,3,5]
Output: [1,3,5], [1,5,3], [3,1,5], [3,5,1], [5,1,3], [5,3,1]

Constraints:

    1 <= nums.length <= 6
    -10 <= nums[i] <= 10
    All the numbers of nums are unique.

*/

// public class Solution
// {

//     public List<List<int>> findPermutations(int[] nums)
//     {
//         List<List<int>> result = new List<List<int>>();
//         // TODO: Write your code here
//         return result;
//     }
// }

public class Solution
{
    public List<List<int>> findPermutations(int[] nums)
    {
        List<List<int>> result = [];
        Queue<List<int>> permutations = new();
        permutations.Enqueue([]);
        foreach (int currentNumber in nums)
        {
            // we will take all existing permutations and add the current number to create 
            // new permutations
            int n = permutations.Count; //remember the length of Queue since the size of Q is changing.
            for (int i = 0; i < n; i++)
            {
                List<int> oldPermutation = permutations.Dequeue();
                // create a new permutation by adding the current number at every position
                for (int j = 0; j <= oldPermutation.Count; j++)
                {
                    List<int> newPermutation = [.. oldPermutation];
                    newPermutation.Insert(j, currentNumber);
                    if (newPermutation.Count == nums.Length)
                        result.Add(newPermutation);
                    else
                        permutations.Enqueue(newPermutation);
                }
            }
        }

        return result;
    }
}

/*

*/

namespace Programming.Patterns.KMerge.KthSmallestInMSortedList;
/*
Kth Smallest Number in M Sorted Lists 
Problem Statement

Given ‘M’ sorted arrays, find the K’th smallest number among all the arrays.

Example 1:

Input: L1=[2, 6, 8], L2=[3, 6, 7], L3=[1, 3, 4], K=5
Output: 4
Explanation: The 5th smallest number among all the arrays is 4, this can be verified from 
the merged list of all the arrays: [1, 2, 3, 3, 4, 6, 6, 7, 8]

Example 2:

Input: L1=[5, 8, 9], L2=[1, 7], K=3
Output: 7
Explanation: The 3rd smallest number among all the arrays is 7.

*/

using System;
using System.Collections.Generic;
using System.Formats.Tar;

public class Solution
{

    public int findKthSmallest(List<List<int>> lists, int k)
    {
        PriorityQueue<int, int> pq = new();
        while (true)
        {
            bool has_element = false;
            for (var i = 0; i < lists.Count; i++)
            {
                if (lists[i].Count > 0)
                {
                    has_element = true;
                    if (pq.Count > k && lists[i][0] > pq.Peek()) continue;

                    pq.Enqueue(lists[i][0], 0 - lists[i][0]);
                    lists[i].RemoveAt(0);
                    if (pq.Count > k)
                    {
                        pq.Dequeue();
                    }
                }

            }

            if (!has_element)
                break;
        }

        return pq.Peek();
    }
}

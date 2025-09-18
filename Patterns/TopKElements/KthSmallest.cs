namespace Programming.Patterns.TopKElements.KthSmallest;
/*
Kth Smallest Number (easy)

Problem Statement

Given an unsorted array of numbers, find Kth smallest number in it.

Please note that it is the Kth smallest number in the sorted order, not the Kth distinct element.

Note: For a detailed discussion about different approaches to solve this problem, take a look at Kth Smallest Number.

Example 1:

Input: [1, 5, 12, 2, 11, 5], K = 3
Output: 5
Explanation: The 3rd smallest number is '5', as the first two smaller numbers are [1, 2].

Example 2:

Input: [1, 5, 12, 2, 11, 5], K = 4
Output: 5
Explanation: The 4th smallest number is '5', as the first three small numbers are [1, 2, 5].

Example 3:

Input: [5, 12, 11, -1, 12], K = 3
Output: 11
Explanation: The 3rd smallest number is '11', as the first two small numbers are [5, -1].

Constraints:

    1 <= k <= nums.length <= 105
    -104 <= nums[i] <= 104

*/


using System;
using System.Collections.Generic;

public class Solution
{

    public int findKthSmallestNumber(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || nums.Length < k || k <= 0) throw new ArgumentException();
        List<int> heap = [];
        for (var i = 0; i < nums.Length; i++)
        {
            BuildMaxHeap(heap, nums[i], k);
        }
        return heap[0];
    }

    private void BuildMaxHeap(List<int> heap, int val, int k)
    {
        if (heap.Count < k)
        {
            heap.Insert(0, val);
            BubbleDown(heap, 0, heap.Count);
            return;
        }

        if (val >= heap[0]) return;

        if (heap.Count == k)
        {
            heap.RemoveAt(0);
        }

        heap.Insert(0, val);
        BubbleDown(heap, 0, heap.Count);
    }

    private void BubbleDown(List<int> heap, int i, int n)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int target_index = i;
        if (left < n && heap[i] < heap[left])
        {
            target_index = left;
        }

        if (right < n && heap[target_index] < heap[right])
        {
            target_index = right;
        }

        if (target_index != i)
        {
            (heap[i], heap[target_index]) = (heap[target_index], heap[i]);
        }
    }
}


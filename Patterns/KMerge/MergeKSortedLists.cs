namespace Programming.Patterns.KMerge.MergeKSortedLists;

/*
Merge K Sorted Lists (medium)
Problem Statement

Given an array of ‘K’ sorted LinkedLists, merge them into one sorted list.

Example 1:

Input: L1=[2, 6, 8], L2=[3, 6, 7], L3=[1, 3, 4]
Output: [1, 2, 3, 3, 4, 6, 6, 7, 8]

Example 2:

Input: L1=[5, 8, 9], L2=[1, 7]
Output: [1, 5, 7, 8, 9]

Constraints:

    k == lists.length
    0 <= k <= 104
    0 <= lists[i].length <= 500
    -104 <= lists[i][j] <= 104
    lists[i] is sorted in ascending order.
    The sum of lists[i].length will not exceed 104.

*/

using System;
using System.Collections.Generic;

public class ListNode
{
    public int Val;
    public ListNode? Next;

    public ListNode(int Val)
    {
        this.Val = Val;
    }
}

public class Solution
{

    public ListNode? merge(ListNode[] lists)
    {
        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();
        foreach (var node in lists)
        {
            if (node != null)
            {
                minHeap.Enqueue(node, node.Val);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (minHeap.Count > 0)
        {
            var node = minHeap.Dequeue();
            current.Next = node;
            current = current.Next;
            if (node.Next != null)
            {
                minHeap.Enqueue(node.Next, node.Next.Val);
            }
        }

        return dummy.Next;
    }
    public ListNode? merge2(ListNode[] lists)
    {
        if (lists.Length == 0) return null;
        ListNode? resultHead = null;

        SortedDictionary<int, List<ListNode>> mhp = [];
        foreach (var node in lists)
        {
            if (node == null) continue;
            if (!mhp.ContainsKey(node.Val)) mhp.Add(node.Val, []);
            mhp[node.Val].Add(node);
        }

        if (mhp.Count == 0) return null;
        var first_list = mhp.First().Value;
        resultHead = first_list[0];
        var current = resultHead;
        for (var i = 1; i < first_list.Count; i++)
        {
            if (first_list[i] == null) continue;
            current.Next = first_list[i];
            current = first_list[i];
        }

        while (mhp.Count > 0)
        {
            List<ListNode> original = [];
            var next_list = mhp.First().Value;
            for (var i = 0; i < next_list.Count; i++)
            {
                if (next_list[i] == null) continue;
                if (next_list[i].Next != null)
                    original.Add(next_list[i].Next!);

                current.Next = next_list[i];
                current = next_list[i];
            }

            mhp.Remove(mhp.First().Key);

            if (original.Count > 0)
            {
                foreach (var o in original)
                {
                    if (!mhp.ContainsKey(o.Val))
                        mhp.Add(o.Val, []);

                    mhp[o.Val].Add(o);
                }
            }

        }

        return resultHead;
    }
}

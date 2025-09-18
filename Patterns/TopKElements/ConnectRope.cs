namespace Programming.Patterns.TopKElements.ConnectRope;

/*
Connect Ropes 
Problem Statement

Given ‘N’ ropes with different lengths, we need to connect these ropes into one big rope with minimum cost. The cost of connecting two ropes is equal to the sum of their lengths.

Example 1:

Input: [1, 3, 11, 5]
Output: 33
Explanation: First connect 1+3(=4), then 4+5(=9), and then 9+11(=20). So the total cost is 33 (4+9+20)

Example 2:

Input: [3, 4, 5, 6]
Output: 36
Explanation: First connect 3+4(=7), then 5+6(=11), 7+11(=18). Total cost is 36 (7+11+18)

Example 3:

Input: [1, 3, 11, 5, 2]
Output: 42
Explanation: First connect 1+2(=3), then 3+3(=6), 6+5(=11), 11+11(=22). Total cost is 42 (3+6+11+22)

Constraints:

    1 <= ropLengths.length <= 104
    1 <= ropLengths[i] <= 104

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class Solution
{
    public int minimumCostToConnectRopes(int[] ropeLengths)
    {
        SortedDictionary<int, int> minHeap = new SortedDictionary<int, int>();
        
        // add all ropes to the min heap
        foreach (var length in ropeLengths)
        {
            if (!minHeap.ContainsKey(length))
                minHeap[length] = 0;
            minHeap[length]++;
        }

        int result = 0, temp = 0;
        while (minHeap.Count > 1 || minHeap.First().Value > 1)
        {
            temp = GetSmallestFromHeap(minHeap) + GetSmallestFromHeap(minHeap);
            result += temp;

            if (!minHeap.ContainsKey(temp))
                minHeap[temp] = 0;
            minHeap[temp]++;
        }

        return result;
    }

    private int GetSmallestFromHeap(SortedDictionary<int, int> heap)
    {
        var smallestEntry = heap.First();
        int smallestKey = smallestEntry.Key;
        heap[smallestKey]--;
        if (heap[smallestKey] == 0)
            heap.Remove(smallestKey);
        return smallestKey;
    }
}

/*
solution: always sum the two smallest numbers.
*/

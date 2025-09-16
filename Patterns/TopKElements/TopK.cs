namespace Programming.Patterns.TopKElements.TopK;

/*
Top 'K' Numbers (easy)
Problem Statement

Given an unsorted array of numbers, find the ‘K’ largest numbers in it.

Example 1:

Input: [3, 1, 5, 12, 2, 11], K = 3
Output: [5, 12, 11]

Example 2:

Input: [5, 12, 11, -1, 12], K = 3
Output: [12, 11, 12]

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
    public List<int> findKLargestNumbers(int[] nums, int k)
    {
        List<int> numbers = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            BuildMinHeap(numbers, nums[i], k);
        }

        return numbers;
    }

    private void BuildMinHeap(List<int> numbers, int newVal, int k)
    {
        int n = numbers.Count;
        if (n < k)
        {
            numbers.Insert(0, newVal);
            if (n > 0)
            {
                BubbleDown(numbers, 0);
            }
            return;
        }

        if (numbers[0] < newVal)
        {
            numbers[0] = newVal;
            BubbleDown(numbers, 0);
        }
    }

    private void BubbleDown(List<int> numbers, int index)
    {
        // min heap
        var left_child = 2 * index + 1;
        var right_child = 2 * index + 2;
        int n = numbers.Count;
        int smallest = index;
        if (left_child < n && numbers[index] > numbers[left_child])
        {
            smallest = left_child;
        }

        if (right_child < n && numbers[smallest] > numbers[right_child])
        {
            smallest = right_child;
        }

        if (smallest != index)
        {
            (numbers[smallest], numbers[index]) = (numbers[index], numbers[smallest]);
            BubbleDown(numbers, smallest);
        }
    }
}

/* the time complexity of above solution is approximately O(n * Log(k))

note: a easy solution would be use Array.Sort to sort the nums first, which time complexity would be O(n * Log(n))
*/
namespace Programming.Patterns.ModifiedBinarySearch.NumberRange;
/*
Number Range (medium)
Problem Statement

Given an array of numbers sorted in ascending order, find the range of a given number ‘key’. The range of the ‘key’ will be the first and last position of the ‘key’ in the array.

Write a function to return the range of the ‘key’. If the ‘key’ is not present return [-1, -1].

Example 1:

Input: [4, 6, 6, 6, 9], key = 6
Output: [1, 3]

Example 2:

Input: [1, 3, 8, 10, 15], key = 10
Output: [3, 3]

Example 3:

Input: [1, 3, 8, 10, 15], key = 12
Output: [-1, -1]

Constraints:

    0 <= nums.length <= 105
    -109 <= nums[i] <= 109
    nums is a non-decreasing array.
    -109 <= target <= 109

*/

public class Solution
{
    public int[] findRange(int[] arr, int key)
    {
        int[] result = new int[] { -1, -1 };
        result[0] = Search(arr, key, false);
        if (result[0] != -1) // no need to search, if 'key' is not present in the input array
            result[1] = Search(arr, key, true);
        return result;
    }

    // modified Binary Search
    private int Search(int[] arr, int key, bool findMaxIndex)
    {
        int keyIndex = -1;
        int start = 0, end = arr.Length - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (key < arr[mid])
            {
                end = mid - 1;
            }
            else if (key > arr[mid])
            {
                start = mid + 1;
            }
            else // key == arr[mid]
            {
                keyIndex = mid;
                if (findMaxIndex)
                    start = mid + 1; // search ahead to find the last index of 'key'
                else
                    end = mid - 1; // search behind to find the first index of 'key'
            }
        }
        return keyIndex;
    }
}

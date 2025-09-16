namespace Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray;

/*
Search in a Sorted Infinite Array (medium)

Problem Statement

Given an infinite sorted array (or an array with unknown size), find if a given number ‘key’ is present in the array. Write a function to return the index of the ‘key’ if it is present in the array, otherwise return -1.

Since it is not possible to define an array with infinite (unknown) size, you will be provided with an interface ArrayReader to read elements of the array. ArrayReader.get(index) will return the number at index; if the array’s size is smaller than the index, it will return Integer.MAX_VALUE.

Example 1:

Input: [4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30], key = 16
Output: 6
Explanation: The key is present at index '6' in the array.

Example 2:

Input: [4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30], key = 11
Output: -1
Explanation: The key is not present in the array.

Example 3:

Input: [1, 3, 8, 10, 15], key = 15
Output: 4
Explanation: The key is present at index '4' in the array.

Example 4:

Input: [1, 3, 8, 10, 15], key = 200
Output: -1
Explanation: The key is not present in the array.

Constraints:

    1 <= reader.length <= 104
    -104 <= reader[i], target <= 104
    reader is sorted in a strictly increasing order.

*/

public class ArrayReader
{
    public int[] Arr { get; private set; }

    public ArrayReader(int[] arr)
    {
        this.Arr = arr;
    }

    public int Get(int index)
    {
        if (index >= Arr.Length)
            return int.MaxValue;
        return Arr[index];
    }
}

public class Solution
{
    public int searchInfiniteSortedArray(ArrayReader reader, int key)
    {
        int start = 0;
        int end = 1;
        while (reader.Get(end) < key)
        {
            int newstart = end + 1;
            end = (end - start + 1) * 2;
            start = newstart;
        }


        return BinarySearch(reader, start, end, key);
    }

    private int BinarySearch(ArrayReader reader, int start, int end, int key)
    {
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int val = reader.Get(mid);
            if (key < val)
            {
                end = mid - 1;
            }
            else if (key > val)
            {
                start = mid + 1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}

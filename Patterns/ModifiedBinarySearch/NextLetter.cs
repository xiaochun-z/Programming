namespace Programming.Patterns.ModifiedBinarySearch.NextLetter;

/*
Next Letter (medium)
Problem Statement

Given an array of lowercase letters sorted in ascending order, find the smallest letter in the given array greater than a given ‘key’.

Assume the given array is a circular list, which means that the last letter is assumed to be connected with the first letter. This also means that the smallest letter in the given array is greater than the last letter of the array and is also the first letter of the array.

Write a function to return the next letter of the given ‘key’.

Example 1:

Input: ['a', 'c', 'f', 'h'], key = 'f'
Output: 'h'
Explanation: The smallest letter greater than 'f' is 'h' in the given array.

Example 2:

Input: ['a', 'c', 'f', 'h'], key = 'b'
Output: 'c'
Explanation: The smallest letter greater than 'b' is 'c'.

Example 3:

Input: ['a', 'c', 'f', 'h'], key = 'm'
Output: 'a'
Explanation: As the array is assumed to be circular, the smallest letter greater than 'm' is 'a'.

Example 4:

Input: ['a', 'c', 'f', 'h'], key = 'h'
Output: 'a'
Explanation: As the array is assumed to be circular, the smallest letter greater than 'h' is 'a'.

Constraints:

    2 <= letters.length <= 104
    letters[i] is a lowercase English letter.
    letters is sorted in non-decreasing order.
    letters contains at least two different characters.
    key is a lowercase English letter.

*/

using System;
using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public char searchNextLetter(char[] letters, char key)
    {
        int n = letters.Length;

        int start = 0, end = n - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (key < letters[mid])
            {
                end = mid - 1;
            }
            else  //if (key >= letters[mid]) 
            {
                start = mid + 1;
            }
        }
        // since the loop is running until 'start <= end', so at the end of the while loop, 
        // 'start == end+1'
        return letters[start % n];
    }
}
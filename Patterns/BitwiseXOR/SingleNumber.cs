namespace Programming.Patterns.BitwiseXOR.SingleNumber;

/*
Single Number (easy)
Problem Statement

In a non-empty array of integers, every number appears twice except for one, find that single number.

Example 1:

Input: 1, 4, 2, 1, 3, 2, 3
Output: 4

Example 2:

Input: 7, 9, 7
Output: 9

Constraints:

    1 <= nums.length <= 3 * 104
    -3 * 104 <= nums[i] <= 3 * 104
    Each element in the array appears twice except for one element which appears only once.

*/

using System;

public class Solution {
    // Find the single number in an array where every other number is repeated twice.
    public int findSingleNumber(int[] arr) {
        int num = arr[0];
        for (var i = 1; i < arr.Length; i++)
        {
            num = num ^ arr[i];
        }
        return num;
    }
}

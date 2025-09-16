namespace Programming.Patterns.BitwiseXOR.TwoSingleNumbers;

/*
Two Single Numbers (medium)
Problem Statement

In a non-empty array of numbers, every number appears exactly twice except two numbers that appear only once. Find the two numbers that appear only once.

Example 1:

Input: [1, 4, 2, 1, 3, 5, 6, 2, 3, 5]
Output: [4, 6]

Example 2:

Input: [2, 1, 3, 2]
Output: [1, 3]

Constraints:

    1 <= nums.length <= 3 * 104
    -3 * 104 <= nums[i] <= 3 * 104
    Each element in the array appears twice except for two element which appears only once.

*/

using System;

public class Solution
{
    public int[] findSingleNumbers(int[] nums)
    {
        int axorb = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            axorb ^= nums[i];
        }

        var right1bit = 1;
        while ((axorb & right1bit) == 0)
        {
            right1bit <<= 1;
        }

        int nums1 = 0;
        int nums2 = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if ((nums[i] & right1bit) == 0)
            {
                nums1 ^= nums[i];
            }
            else
            {
                nums2 ^= nums[i];
            }
        }

        return [nums1, nums2];
    }
}

namespace Programming.Patterns.CycleSort.FindMissingNum;

/*
Find the Missing Number (easy)

Problem Statement

We are given an array containing n distinct numbers taken from the range 0 to n. Since the array has only n numbers out of the total n+1 numbers, find the missing number.

Example 1:

Input: [4, 0, 3, 1]
Output: 2

Example 2:

Input: [8, 3, 5, 2, 4, 6, 0, 1]
Output: 7

Constraints:

    n == nums.length
    1 <= n <= 

0 <= nums[i] <= n
All the numbers of nums are unique.
*/

using System;

public class Solution
{

  public int findMissingNumber(int[] nums)
  {
    var i = 0;
    while (i < nums.Length)
    {
      var j = nums[i];

      if (j < nums.Length && nums[i] != nums[j])
        (nums[i], nums[j]) = (nums[j], nums[i]);
      else
      {
        i++;
      }

    }

    for (i = 0; i < nums.Length; i++)
    {
      if (i != nums[i])
      {
        return i;
      }
    }
    return nums.Length;
  }
}

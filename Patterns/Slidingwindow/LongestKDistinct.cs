namespace Programming.Patterns.Slidingwindow.LongestKDisctinct;

using System;
using System.Collections.Generic;

/*
Longest Substring with K Distinct Characters (medium)

Problem Statement

Given a string, find the length of the longest substring in it with no more than K distinct characters.

You can assume that K is less than or equal to the length of the given string.

Example 1:

Input: String="araaci", K=2  
Output: 4  
Explanation: The longest substring with no more than '2' distinct characters is "araa".

Example 2:

Input: String="araaci", K=1  
Output: 2  
Explanation: The longest substring with no more than '1' distinct characters is "aa".

Example 3:

Input: String="cbbebi", K=3  
Output: 5  
Explanation: The longest substrings with no more than '3' distinct characters are "cbbeb" & "bbebi".

Constraints:

    1 <= str.length <= 5 * 104
    0 <= K <= 50

*/
public class Solution
{
    public int findLength(string str, int k)
    {
        int maxLength = 0;
        int start = 0, end = 0;
        Dictionary<char, int> dict = [];
        for (var i = 0; i < str.Length; i++)
        {
            dict[str[i]] = dict.GetValueOrDefault(str[i], 0) + 1;
            end++;

            while (dict.Count() > k)
            {
                var count = dict[str[start]] -= 1;
                if (count == 0) dict.Remove(str[start]);
                start++;

            }
            maxLength = Math.Max(maxLength, end - start);
        }

        return maxLength;
    }
}
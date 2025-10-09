namespace Programming.Patterns.Palindromic.LongestPalindromicSubsequence;

/*
Problem Statement
Given a sequence, find the length of its Longest Palindromic Subsequence (LPS). In a palindromic subsequence, elements read the same backward and forward.

A subsequence is a sequence that can be derived from another sequence by deleting some or no elements without changing the order of the remaining elements.

Example 1:

Input: "abdbca"
Output: 5
Explanation: LPS is "abdba".
Example 2:

Input: = "cddpd"
Output: 3
Explanation: LPS is "ddd".
Example 3:

Input: = "pqr"
Output: 1
Explanation: LPS could be "p", "q" or "r".
Constraints:

1 <= st.length <= 1000
sy consists only of lowercase English letters.
*/

using System;
public class Solution
{
    public int findLPSLength(string st)
    {
        return findLPSLengthInternal(st, 0, st.Length-1);
    }

    private int findLPSLengthInternal(string st, int i, int j)
    {
        if (i > j) return 0;
        if (i == j) return 1;

        if (st[i] == st[j])
        {
            return 2 + findLPSLengthInternal(st, i + 1, j - 1);
        }

        var c1 = findLPSLengthInternal(st, i + 1, j);
        var c2 = findLPSLengthInternal(st, i, j - 1);

        return Math.Max(c1, c2);
    }
}

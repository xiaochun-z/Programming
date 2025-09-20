namespace Programming.Patterns.Greedy.ValidPalindromeII;

/*
Problem Statement

Given string s, determine whether it's possible to make a given string palindrome by removing at most one character.

A palindrome is a word or phrase that reads the same backward as forward.
Examples

    Example 1:
        Input: "racecar"
        Expected Output: true
        Justification: The string is already a palindrome, so no removals are needed.

    Example 2:
        Input: "abccdba"
        Expected Output: true
        Justification: Removing the character 'd' forms the palindrome "abccba".

    Example 3:
        Input: "abcdef"
        Expected Output: false
        Justification: No single character removal will make this string a palindrome.

Constraints:

    1 <= s.length <= 105
    str consists of lowercase English letters.

*/

using System;

public class Solution
{
    public bool isPalindromePossible(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        while (i <= j)
        {
            if (!IsPalindrome(s, i, j))
            {
                return IsPalindrome(s, i + 1, j) || IsPalindrome(s, i, j - 1);
            }
            i++;
            j--;
        }
        return true;
    }

    private bool IsPalindrome(string s, int i, int j)
    {
        return s[i] == s[j];
    }
}

namespace Programming.Patterns.Hashmap.FirstNonRepeatChar;
/*
Problem Statement

Given a string, identify the position of the first character that appears only once in the string. If no such character exists, return -1.

Examples

    Example 1:
        Input: "apple"
        Expected Output: 0
        Justification: The first character 'a' appears only once in the string and is the first character.

    Example 2:
        Input: "abcab"
        Expected Output: 2
        Justification: The first character that appears only once is 'c' and its position is 2.

    Example 3:
        Input: "abab"
        Expected Output: -1
        Justification: There is no character in the string that appears only once.

Constraints:

    1 <= s.length <= 105
    s consists of only lowercase English letters.

*/
using System;
using System.Collections.Generic;

public class Solution {
    public int firstUniqChar(string s) {
        Dictionary<char, int> hash = new();
        foreach (char c in s)
        {
            hash[c] = hash.GetValueOrDefault(c, 0) + 1;
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (hash[s[i]] == 1)
                return i;
        }

        return -1;
    }
}

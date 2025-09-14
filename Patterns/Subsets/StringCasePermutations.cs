namespace Programming.Patterns.Subsets.StringCasePermutations;

/*
String Permutations by changing case (medium)
Problem Statement

Given a string, find all of its permutations preserving the character sequence but changing case.

Example 1:

Input: "ad52"
Output: "ad52", "Ad52", "aD52", "AD52"

Example 2:

Input: "ab7c"
Output: "ab7c", "Ab7c", "aB7c", "AB7c", "ab7C", "Ab7C", "aB7C", "AB7C"

Constraints:

    1 <= str.length <= 12
    str consists of lowercase English letters, uppercase English letters, and digits.

*/

using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

public class Solution
{
    public List<string> findLetterCaseStringPermutations(string str)
    {
        List<string> permutations = new List<string>();

        permutations.Add(str);
        // process every character of the string one by one
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsLetter(str[i]))
            { // only process characters, skip digits
              // we'll take all existing permutations and change the letter case appropriately
                int n = permutations.Count;
                for (int j = 0; j < n; j++)
                {
                    char[] chs = permutations[j].ToCharArray();
                    // if the current char is in upper case change it to lower case or vice versa
                    if (Char.IsUpper(chs[i]))
                        chs[i] = Char.ToLower(chs[i]);
                    else
                        chs[i] = Char.ToUpper(chs[i]);
                    permutations.Add(new string(chs));
                }
            }
        }
        return permutations;
    }
}

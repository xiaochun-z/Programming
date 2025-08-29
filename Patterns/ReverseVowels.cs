namespace Programming.Patterns.ReverseVowels;

using System;

public class Solution
{
    static readonly string vowels = "aeiouAEIOU";

    public string reverseVowels(string s)
    {
        var chars = s.ToCharArray();
        int i = 0, j = chars.Length - 1;
        while (i < j)
        {
            if (!vowels.Contains(chars[i]))
            {
                i++;
                continue;
            }
            if (!vowels.Contains(chars[j]))
            {
                j--;
                continue;
            }
            (chars[i], chars[j]) = (chars[j], chars[i]);
            i++;
            j--;
        }
        return new string(chars);
    }
}
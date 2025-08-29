namespace Programming.Patterns.Angram;

public class Solution
{
  public bool isAnagram(string s, string t)
  {
    if (s.Length != t.Length) return false;
    int[] count = new int[26];
    for (var i = 0; i < s.Length; i++)
    {
      count[s[i] - 'a']++;
      count[t[i] - 'a']--;
    }
    for (var i = 0; i < 26; i++)
    {
      if (count[i] != 0) return false;
    }
    return true;
  }
}
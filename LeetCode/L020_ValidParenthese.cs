namespace LeetCode.L020_ValidParenthese;

// LeetCode 020: Valid Parentheses: https://leetcode.com/problems/valid-parentheses/description/
public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> m = new Dictionary<char, char>{
            {')','('},
            {']','['},
            {'}','{'}
            };
        Stack<char> q = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                q.Push(c);
                continue;
            }

            if (c == ')' || c == ']' || c == '}')
            {
                if (q.Count == 0)
                {
                    return false;
                }
                char d = q.Pop();
                if (m[c] != d)
                    return false;
            }
        }

        if (q.Count == 0)
            return true;
        return false;
    }
}


namespace Programming.Patterns.Palindrome;
public class Solution
{

    public bool isPalindrome(string s)
    {
        char[] arr = s.ToCharArray();
        int i = 0, j = arr.Length - 1;
        while (i < j)
        {
            if(!char.IsLetterOrDigit(arr[i]))
            {
                i++;
                continue;
            }
            
            if(!char.IsLetterOrDigit(arr[j]))
            {
                j--;
                continue;
            }

            if (char.ToLower(arr[i]) != char.ToLower(arr[j]))
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

}
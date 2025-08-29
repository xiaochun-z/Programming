namespace Programming.Patterns.ShortestWordDistance;

public class Solution
{
    public int shortestDistance(string[] words, string word1, string word2)
    {
        int idx1 = -1, idx2 = -1, min = int.MaxValue;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == word1)
            {
                idx1 = i;
            }
            else if (words[i] == word2)
            {
                idx2 = i;
            }

            if (idx1 != -1 && idx2 != -1)
            {
                min = Math.Min(min, Math.Abs(idx1 - idx2));
            }
        }
        if (min != int.MaxValue)
        {
            return min;
        }
        return 1;
    }
}
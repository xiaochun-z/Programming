namespace Programming.Patterns.GoodPairs;
public class Solution
{
    public int numGoodPairs(int[] nums)
    {
        int pairCount = 0;
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                pairCount += dict[num];
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }
        return pairCount;
    }
}
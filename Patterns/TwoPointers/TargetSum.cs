namespace Programming.Patterns.TwoPointers.TargetSum;

public class Solution
{
    public int[] search(int[] arr, int targetSum)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int currentSum = arr[left] + arr[right];
            if (currentSum == targetSum)
            {
                return [left, right];
            }
            else if (currentSum < targetSum)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return [-1, -1];
    }
}
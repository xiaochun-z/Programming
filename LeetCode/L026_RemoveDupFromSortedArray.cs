namespace LeetCode.RemoveDupFromSortedArray;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int uniqueIndex = 0;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[uniqueIndex]) {
                uniqueIndex++;
                nums[uniqueIndex] = nums[i];
            }
        }

        return uniqueIndex + 1;       
    }
}
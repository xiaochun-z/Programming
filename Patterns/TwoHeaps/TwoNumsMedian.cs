namespace Programming.Patterns.TwoHeaps.TwoNumsMedian;
/*

4. Median of Two Sorted Arrays
https://leetcode.com/problems/median-of-two-sorted-arrays/description/

Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

 

Constraints:

    nums1.length == m
    nums2.length == n
    0 <= m <= 1000
    0 <= n <= 1000
    1 <= m + n <= 2000
    -106 <= nums1[i], nums2[i] <= 106


*/

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1 == null || nums2 == null)
            throw new ArgumentNullException("Input arrays cannot be null");
        if (!IsSorted(nums1) || !IsSorted(nums2))
            throw new ArgumentException("Input arrays must be sorted");

        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int x = nums1.Length, y = nums2.Length;
        int low = 0, high = x;

        while (low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = (x + y + 1) / 2 - partitionX;

            int maxLeftX = partitionX == 0 ? int.MinValue : nums1[partitionX - 1];
            int minRightX = partitionX == x ? int.MaxValue : nums1[partitionX];
            int maxLeftY = partitionY == 0 ? int.MinValue : nums2[partitionY - 1];
            int minRightY = partitionY == y ? int.MaxValue : nums2[partitionY];

            if (maxLeftX <= minRightY && maxLeftY <= minRightX)
            {
                if ((x + y) % 2 == 0)
                    return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                return Math.Max(maxLeftX, maxLeftY);
            }
            else if (maxLeftX > minRightY)
                high = partitionX - 1;
            else
                low = partitionX + 1;
        }

        throw new InvalidOperationException("Input arrays are not sorted");
    }

    private bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] < arr[i - 1])
                return false;
        return true;
    }
    
    public double FindMedianSortedArrays2(int[] nums1, int[] nums2)
    {
        List<int> max_heap = [];
        List<int> min_heap = [];

        int[] arr = nums1;
        for (var i = 0; i < nums1.Length + nums2.Length; i++)
        {
            int index = i;
            if (i >= nums1.Length)
            {
                arr = nums2;
                index = i - nums1.Length;
            }

            if (max_heap.Count == 0)
            {
                max_heap.Add(arr[index]);
            }
            else
            {
                if (arr[index] < max_heap[0])
                {
                    max_heap.Add(arr[index]);
                    BubbleUp(max_heap, false);

                    if (max_heap.Count > min_heap.Count + 1)
                    {
                        int val = max_heap[0];
                        max_heap[0] = max_heap[max_heap.Count - 1];
                        max_heap.RemoveAt(max_heap.Count - 1);
                        BubbleDown(max_heap, false);

                        min_heap.Add(val);
                        BubbleUp(min_heap, true);

                    }
                }
                else
                {
                    min_heap.Add(arr[index]);
                    BubbleUp(min_heap, true);

                    if (min_heap.Count > max_heap.Count)
                    {
                        int val = min_heap[0];
                        min_heap[0] = min_heap[min_heap.Count - 1];
                        min_heap.RemoveAt(min_heap.Count - 1);
                        BubbleDown(min_heap, true);

                        max_heap.Add(val);
                        BubbleUp(max_heap, false);
                    }
                }
            }
        }

        if (max_heap.Count > min_heap.Count)
            return max_heap[0];
        return (max_heap[0] + min_heap[0]) / 2d;
    }

    private void BubbleUp(List<int> nums, bool min)
    {
        if (nums.Count <= 1) return;

        int index = nums.Count - 1;
        int parent = (index - 1) / 2;

        while (index > 0 && ((min && nums[index] < nums[parent]) || (!min && nums[index] > nums[parent])))
        {
            (nums[index], nums[parent]) = (nums[parent], nums[index]);
            index = parent;
            parent = (index - 1) / 2;
        }
    }

    private void BubbleDown(List<int> nums, bool min)
    {
        int index = 0;
        while (true)
        {
            int left_child = 2 * index + 1;
            int right_child = 2 * index + 2;
            int target_index = index;

            if (min)
            {
                if (left_child < nums.Count && nums[left_child] < nums[target_index])
                    target_index = left_child;
                if (right_child < nums.Count && nums[right_child] < nums[target_index])
                    target_index = right_child;
            }
            else
            {
                if (left_child < nums.Count && nums[left_child] > nums[target_index])
                    target_index = left_child;
                if (right_child < nums.Count && nums[right_child] > nums[target_index])
                    target_index = right_child;
            }

            if (target_index == index)
                break;

            (nums[index], nums[target_index]) = (nums[target_index], nums[index]);
            index = target_index;
        }
    }
}
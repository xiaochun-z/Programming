namespace LeetCodeTests;

[TestClass]
public sealed class L_020_ValidParenthese
{
    [TestMethod]
    public void Test_020_ValidParenthese()
    {
        var solution = new LeetCode.L020_ValidParenthese.Solution();
        Assert.IsTrue(solution.IsValid("(6,5)-(14,6)"));
        Assert.IsTrue(solution.IsValid("()"));
        Assert.IsTrue(solution.IsValid("()[]{}"));
        Assert.IsFalse(solution.IsValid("(]"));
        Assert.IsTrue(solution.IsValid("([])"));
        Assert.IsFalse(solution.IsValid("([)]"));
    }

    [TestMethod]
    public void Test_021_MergeSortedList()
    {
        var solution = new LeetCode.L021_MergeTwoSortedList.Solution();
        var list1 = new LeetCode.L021_MergeTwoSortedList.ListNode(1, new LeetCode.L021_MergeTwoSortedList.ListNode(2, new LeetCode.L021_MergeTwoSortedList.ListNode(4)));
        var list2 = new LeetCode.L021_MergeTwoSortedList.ListNode(1, new LeetCode.L021_MergeTwoSortedList.ListNode(3, new LeetCode.L021_MergeTwoSortedList.ListNode(4)));

        var result = LeetCode.L021_MergeTwoSortedList.Solution.MergeTwoLists(list1, list2);
        int[] expected = [1, 1, 2, 3, 4, 4];
        Assert.IsNotNull(result);
        CollectionAssert.AreEqual(expected, actual: result.ToArray());
    }

    [TestMethod]
    public void Test_026_RemoveDupFromSortedArray()
    {
        var solution = new LeetCode.RemoveDupFromSortedArray.Solution();
        int[] nums = [1, 1, 2];
        int k = solution.RemoveDuplicates(nums);
        Assert.AreEqual(2, k);
        CollectionAssert.AreEqual(new int[] { 1, 2 }, nums[..k]);

        nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        k = solution.RemoveDuplicates(nums);
        Assert.AreEqual(5, k);
        int[] expected = [0, 1, 2, 3, 4];
        CollectionAssert.AreEqual(expected, nums[..k]);
    }
}

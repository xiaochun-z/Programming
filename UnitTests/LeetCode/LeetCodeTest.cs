namespace LeetCodeTests;

[TestClass]
public sealed class L_020_ValidParenthese
{
    [TestMethod]
    public void Test_ValidParenthese()
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
    public void Test_MergeSortedList()
    {
        var solution = new LeetCode.L021_MergeTwoSortedList.Solution();
        var list1 = new LeetCode.L021_MergeTwoSortedList.ListNode(1, new LeetCode.L021_MergeTwoSortedList.ListNode(2, new LeetCode.L021_MergeTwoSortedList.ListNode(4)));
        var list2 = new LeetCode.L021_MergeTwoSortedList.ListNode(1, new LeetCode.L021_MergeTwoSortedList.ListNode(3, new LeetCode.L021_MergeTwoSortedList.ListNode(4)));

        var result = solution.MergeTwoLists(list1, list2);
        int[] expected =  [1, 1, 2, 3, 4, 4];
        CollectionAssert.AreEqual(expected, result.ToArray());
    }
}

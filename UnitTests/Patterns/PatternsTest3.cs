
namespace UnitTests;

public partial class Patterns_Tests
{

    [TestMethod]
    public void Test_KthSmallestInMSortedList()
    {
        Programming.Patterns.KMerge.KthSmallestInMSortedList.Solution solution = new();
        // Test Case 1: Example 1 - L1=[2,6,8], L2=[3,6,7], L3=[1,3,4], K=5
        // Expected: 4
        List<List<int>> lists1 =
        [
        [2, 6, 8],
        [3, 6, 7],
        [1, 3, 4]
    ];
        int k1 = 5;
        int result1 = solution.findKthSmallest(lists1, k1);
        Assert.AreEqual(4, result1, "Test Case 1: 5th smallest number in [[2,6,8], [3,6,7], [1,3,4]] should be 4");

        // Test Case 2: Example 2 - L1=[5,8,9], L2=[1,7], K=3
        // Expected: 7
        List<List<int>> lists2 =
        [
        [5, 8, 9],
        [1, 7]
    ];
        int k2 = 3;
        int result2 = solution.findKthSmallest(lists2, k2);
        Assert.AreEqual(7, result2, "Test Case 2: 3rd smallest number in [[5,8,9], [1,7]] should be 7");

        // Test Case 3: Single list with K=1
        // Expected: 1
        List<List<int>> lists3 =
        [
        [1, 2, 3]
    ];
        int k3 = 1;
        int result3 = solution.findKthSmallest(lists3, k3);
        Assert.AreEqual(1, result3, "Test Case 3: 1st smallest number in [[1,2,3]] should be 1");

        // Test Case 4: Multiple lists, K equals total number of elements
        // Expected: 9
        List<List<int>> lists4 =
        [
        [1, 3],
        [2, 4, 9]
    ];
        int k4 = 5;
        int result4 = solution.findKthSmallest(lists4, k4);
        Assert.AreEqual(9, result4, "Test Case 4: 5th smallest number in [[1,3], [2,4,9]] should be 9");

        // Test Case 5: Lists with negative values
        // Expected: -1
        List<List<int>> lists5 =
        [
        [-5, -2, 0],
        [-3, -1]
    ];
        int k5 = 4;
        int result5 = solution.findKthSmallest(lists5, k5);
        Assert.AreEqual(-1, result5, "Test Case 5: 4th smallest number in [[-5,-2,0], [-3,-1]] should be -1");

        // Test Case 6: Single element across all lists, K=1
        // Expected: 5
        List<List<int>> lists6 =
    [
        [5],
        [],
        []
    ];
        int k6 = 1;
        int result6 = solution.findKthSmallest(lists6, k6);
        Assert.AreEqual(5, result6, "Test Case 6: 1st smallest number in [[5], [], []] should be 5");
    }
}
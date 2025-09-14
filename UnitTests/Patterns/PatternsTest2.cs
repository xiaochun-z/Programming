namespace UnitTests;


public partial class Patterns_Tests
{
    [TestMethod]
    public void Test_Subset()
    {
        Programming.Patterns.Subsets.Subset.Solution solution = new();

        // Test case 1: Array with multiple elements
        int[] nums1 = { 1, 2 };
        var result1 = solution.findSubsets(nums1);
        var expected1 = new List<List<int>>
        {
            new List<int> {},
            new List<int> { 1 },
            new List<int> { 2 },
            new List<int> { 1, 2 }
        };
        Assert.AreEqual(expected1.Count, result1.Count, "Test case 1: Incorrect number of subsets");
        for (int i = 0; i < expected1.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected1[i], result1[i], $"Test case 1: Subset {i} does not match");
        }

        // Test case 2: Array with single element
        int[] nums2 = { 1 };
        var result2 = solution.findSubsets(nums2);
        var expected2 = new List<List<int>>
        {
            new List<int> {},
            new List<int> { 1 }
        };
        Assert.AreEqual(expected2.Count, result2.Count, "Test case 2: Incorrect number of subsets");
        for (int i = 0; i < expected2.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected2[i], result2[i], $"Test case 2: Subset {i} does not match");
        }

        // Test case 3: Empty array
        int[] nums3 = { };
        var result3 = solution.findSubsets(nums3);
        var expected3 = new List<List<int>> { new List<int> { } };
        Assert.AreEqual(expected3.Count, result3.Count, "Test case 3: Incorrect number of subsets");
        for (int i = 0; i < expected3.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected3[i], result3[i], $"Test case 3: Subset {i} does not match");
        }

        // Test case 4: Array with three elements
        int[] nums4 = { 1, 2, 3 };
        var result4 = solution.findSubsets(nums4);
        var expected4 = new List<List<int>>
        {
            new List<int> {},
            new List<int> { 1 },
            new List<int> { 2 },
            new List<int> { 1, 2 },
            new List<int> { 3 },
            new List<int> { 1, 3 },
            new List<int> { 2, 3 },
            new List<int> { 1, 2, 3 }
        };
        Assert.AreEqual(expected4.Count, result4.Count, "Test case 4: Incorrect number of subsets");
        for (int i = 0; i < expected4.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected4[i], result4[i], $"Test case 4: Subset {i} does not match");
        }
    }

    [TestMethod]
    public void Test_Subset_Duplicated()
    {
        Programming.Patterns.Subsets.SubsetDup.Solution solution = new();
        // Test case 5: Array with duplicate elements
        int[] nums5 = { 1, 2, 2 };
        var result5 = solution.findSubsets(nums5);
        var expected5 = new List<List<int>>
        {
            new() {},
            new() { 1 },
            new() { 2 },
            new() { 1, 2 },
            new() { 2, 2 },
            new() { 1, 2, 2 }
        };
        Assert.AreEqual(expected5.Count, result5.Count, "Test case 5: Incorrect number of subsets with duplicates");
        for (int i = 0; i < expected5.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected5[i], result5[i], $"Test case 5: Subset {i} does not match");
        }
    }
}
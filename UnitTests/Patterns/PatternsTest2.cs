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

    [TestMethod]
    public void Test_Subset_Permutations()
    {
        Programming.Patterns.Subsets.Permutations.Solution solution = new();

        // Test case 1: Array with three elements
        int[] nums1 = { 1, 3, 5 };
        var result1 = solution.findPermutations(nums1);
        var expected1 = new List<List<int>>
        {
            new List<int> { 1, 3, 5 },
            new List<int> { 1, 5, 3 },
            new List<int> { 3, 1, 5 },
            new List<int> { 3, 5, 1 },
            new List<int> { 5, 1, 3 },
            new List<int> { 5, 3, 1 }
        };
        Assert.AreEqual(expected1.Count, result1.Count, "Test case 1: Incorrect number of permutations");
        for (int i = 0; i < expected1.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected1[i], result1[i], $"Test case 1: Permutation {i} does not match");
        }

        // Test case 2: Array with single element
        int[] nums2 = { 1 };
        var result2 = solution.findPermutations(nums2);
        var expected2 = new List<List<int>>
        {
            new List<int> { 1 }
        };
        Assert.AreEqual(expected2.Count, result2.Count, "Test case 2: Incorrect number of permutations");
        for (int i = 0; i < expected2.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected2[i], result2[i], $"Test case 2: Permutation {i} does not match");
        }

        // Test case 3: Array with two elements
        int[] nums3 = { 1, 2 };
        var result3 = solution.findPermutations(nums3);
        var expected3 = new List<List<int>>
        {
            new List<int> { 1, 2 },
            new List<int> { 2, 1 }
        };
        Assert.AreEqual(expected3.Count, result3.Count, "Test case 3: Incorrect number of permutations");
        for (int i = 0; i < expected3.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected3[i], result3[i], $"Test case 3: Permutation {i} does not match");
        }
    }

    [TestMethod]
    public void Test_LetterCaseStringPermutations()
    {
        Programming.Patterns.Subsets.StringCasePermutations.Solution solution = new();

        // Test case 1: String with letters and digits (Example 1)
        string input1 = "ad52";
        var result1 = solution.findLetterCaseStringPermutations(input1);
        var expected1 = new List<string> { "ad52", "Ad52", "aD52", "AD52" };
        Assert.AreEqual(expected1.Count, result1.Count, "Test case 1: Incorrect number of permutations");
        CollectionAssert.AreEquivalent(expected1, result1, "Test case 1: Permutations do not match");

        // Test case 2: String with letters and digits (Example 2)
        string input2 = "ab7c";
        var result2 = solution.findLetterCaseStringPermutations(input2);
        var expected2 = new List<string> { "ab7c", "Ab7c", "aB7c", "AB7c", "ab7C", "Ab7C", "aB7C", "AB7C" };
        Assert.AreEqual(expected2.Count, result2.Count, "Test case 2: Incorrect number of permutations");
        CollectionAssert.AreEquivalent(expected2, result2, "Test case 2: Permutations do not match");

        // Test case 3: String with only digits
        string input3 = "123";
        var result3 = solution.findLetterCaseStringPermutations(input3);
        var expected3 = new List<string> { "123" };
        Assert.AreEqual(expected3.Count, result3.Count, "Test case 3: Incorrect number of permutations");
        CollectionAssert.AreEquivalent(expected3, result3, "Test case 3: Permutations do not match");

        // Test case 4: Single letter
        string input4 = "z";
        var result4 = solution.findLetterCaseStringPermutations(input4);
        var expected4 = new List<string> { "z", "Z" };
        Assert.AreEqual(expected4.Count, result4.Count, "Test case 4: Incorrect number of permutations");
        CollectionAssert.AreEquivalent(expected4, result4, "Test case 4: Permutations do not match");

        // Test case 5: Empty string
        string input5 = "";
        var result5 = solution.findLetterCaseStringPermutations(input5);
        var expected5 = new List<string> { "" };
        Assert.AreEqual(expected5.Count, result5.Count, "Test case 5: Incorrect number of permutations");
        CollectionAssert.AreEquivalent(expected5, result5, "Test case 5: Permutations do not match");
    }

    [TestMethod]
    public void Test_OrderAgnosticBinarySearch()
    {
        Programming.Patterns.ModifiedBinarySearch.OrderAgnosticBinarySearch.Solution solution = new();

        // Test case 1: Ascending order, key at the end (Example 1)
        int[] arr1 = { 4, 6, 10 };
        int key1 = 10;
        int result1 = solution.search(arr1, key1);
        Assert.AreEqual(2, result1, "Test case 1: Incorrect index for key 10 in ascending array");

        // Test case 2: Ascending order, key in the middle (Example 2)
        int[] arr2 = { 1, 2, 3, 4, 5, 6, 7 };
        int key2 = 5;
        int result2 = solution.search(arr2, key2);
        Assert.AreEqual(4, result2, "Test case 2: Incorrect index for key 5 in ascending array");

        // Test case 3: Descending order, key at the start (Example 3)
        int[] arr3 = { 10, 6, 4 };
        int key3 = 10;
        int result3 = solution.search(arr3, key3);
        Assert.AreEqual(0, result3, "Test case 3: Incorrect index for key 10 in descending array");

        // Test case 4: Descending order, key at the end (Example 4)
        int[] arr4 = { 10, 6, 4 };
        int key4 = 4;
        int result4 = solution.search(arr4, key4);
        Assert.AreEqual(2, result4, "Test case 4: Incorrect index for key 4 in descending array");

        // Test case 5: Single element array, key present
        int[] arr5 = { 5 };
        int key5 = 5;
        int result5 = solution.search(arr5, key5);
        Assert.AreEqual(0, result5, "Test case 5: Incorrect index for key in single-element array");

        // Test case 6: Key not present in ascending array
        int[] arr6 = { 1, 2, 3, 4, 5 };
        int key6 = 7;
        int result6 = solution.search(arr6, key6);
        Assert.AreEqual(-1, result6, "Test case 6: Should return -1 for key not found in ascending array");

        // Test case 7: Array with duplicates, find first occurrence
        int[] arr7 = { 1, 2, 2, 2, 3 };
        int key7 = 2;
        int result7 = solution.search(arr7, key7);
        Assert.IsTrue(result7 >= 1 && result7 <= 3, "Test case 7: Incorrect index for key 2 in array with duplicates");
    }

    [TestMethod]
    public void Test_SearchNextLetter()
    {
        Programming.Patterns.ModifiedBinarySearch.NextLetter.Solution solution = new();

        // Test case 1: Key present in array (Example 1)
        char[] letters1 = { 'a', 'c', 'f', 'h' };
        char key1 = 'f';
        char result1 = solution.searchNextLetter(letters1, key1);
        Assert.AreEqual('h', result1, "Test case 1: Incorrect next letter for key 'f'");

        // Test case 2: Key not in array, between letters (Example 2)
        char[] letters2 = { 'a', 'c', 'f', 'h' };
        char key2 = 'b';
        char result2 = solution.searchNextLetter(letters2, key2);
        Assert.AreEqual('c', result2, "Test case 2: Incorrect next letter for key 'b'");

        // Test case 3: Key greater than all letters, circular (Example 3)
        char[] letters3 = { 'a', 'c', 'f', 'h' };
        char key3 = 'm';
        char result3 = solution.searchNextLetter(letters3, key3);
        Assert.AreEqual('a', result3, "Test case 3: Incorrect next letter for key 'm'");

        // Test case 4: Key is last letter, circular (Example 4)
        char[] letters4 = { 'a', 'c', 'f', 'h' };
        char key4 = 'h';
        char result4 = solution.searchNextLetter(letters4, key4);
        Assert.AreEqual('a', result4, "Test case 4: Incorrect next letter for key 'h'");

        // Test case 5: Array with repeated letters
        char[] letters5 = { 'a', 'b', 'b', 'c' };
        char key5 = 'b';
        char result5 = solution.searchNextLetter(letters5, key5);
        Assert.AreEqual('c', result5, "Test case 5: Incorrect next letter for key 'b' in array with duplicates");

        // Test case 6: Key smaller than all letters
        char[] letters6 = { 'b', 'c', 'd' };
        char key6 = 'a';
        char result6 = solution.searchNextLetter(letters6, key6);
        Assert.AreEqual('b', result6, "Test case 6: Incorrect next letter for key 'a'");
    }

    [TestMethod]
    public void Test_FindMedianSortedArrays()
    {
        Programming.Patterns.TwoHeaps.TwoNumsMedian.Solution solution = new();

        // Test case 1: Example 1 - Odd total length
        int[] nums1_1 = { 1, 3 };
        int[] nums2_1 = { 2 };
        double result1 = solution.FindMedianSortedArrays(nums1_1, nums2_1);
        Assert.AreEqual(2.0, result1, 0.00001, "Test case 1: Incorrect median for [1,3] and [2]");

        // Test case 2: Example 2 - Even total length
        int[] nums1_2 = { 1, 2 };
        int[] nums2_2 = { 3, 4 };
        double result2 = solution.FindMedianSortedArrays(nums1_2, nums2_2);
        Assert.AreEqual(2.5, result2, 0.00001, "Test case 2: Incorrect median for [1,2] and [3,4]");

        // Test case 3: One empty array
        int[] nums1_3 = { };
        int[] nums2_3 = { 1, 2, 3, 4 };
        double result3 = solution.FindMedianSortedArrays(nums1_3, nums2_3);
        Assert.AreEqual(2.5, result3, 0.00001, "Test case 3: Incorrect median for [] and [1,2,3,4]");

        // Test case 4: Both arrays with single element
        int[] nums1_4 = { 1 };
        int[] nums2_4 = { 2 };
        double result4 = solution.FindMedianSortedArrays(nums1_4, nums2_4);
        Assert.AreEqual(1.5, result4, 0.00001, "Test case 4: Incorrect median for [1] and [2]");

        // Test case 5: Arrays with different sizes, odd total length
        int[] nums1_5 = { 1, 2, 3 };
        int[] nums2_5 = { 4, 5 };
        double result5 = solution.FindMedianSortedArrays(nums1_5, nums2_5);
        Assert.AreEqual(3.0, result5, 0.00001, "Test case 5: Incorrect median for [1,2,3] and [4,5]");

        // Test case 6: Both empty arrays (edge case, but valid per constraints)
        int[] nums1_6 = { };
        int[] nums2_6 = { 1 };
        double result6 = solution.FindMedianSortedArrays(nums1_6, nums2_6);
        Assert.AreEqual(1.0, result6, 0.00001, "Test case 6: Incorrect median for [] and [1]");
    }
}
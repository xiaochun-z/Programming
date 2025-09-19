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

    [TestMethod]
    public void Test_FindNumberRange()
    {
        Programming.Patterns.ModifiedBinarySearch.NumberRange.Solution solution = new();
        // Test Case 1: Multiple occurrences of key
        int[] arr1 = { 4, 6, 6, 6, 9 };
        int key1 = 6;
        int[] expected1 = { 1, 3 };

        // Test Case 2: Single occurrence of key
        int[] arr2 = { 1, 3, 8, 10, 15 };
        int key2 = 10;
        int[] expected2 = { 3, 3 };

        // Test Case 3: Key not present
        int[] arr3 = { 1, 3, 8, 10, 15 };
        int key3 = 12;
        int[] expected3 = { -1, -1 };

        // Test Case 4: Empty array
        int[] arr4 = { };
        int key4 = 5;
        int[] expected4 = { -1, -1 };

        // Test Case 5: Single element array, key present
        int[] arr5 = { 1 };
        int key5 = 1;
        int[] expected5 = { 0, 0 };

        // Test Case 6: Single element array, key not present
        int[] arr6 = { 1 };
        int key6 = 2;
        int[] expected6 = { -1, -1 };

        // Act
        int[] result1 = solution.findRange(arr1, key1);
        int[] result2 = solution.findRange(arr2, key2);
        int[] result3 = solution.findRange(arr3, key3);
        int[] result4 = solution.findRange(arr4, key4);
        int[] result5 = solution.findRange(arr5, key5);
        int[] result6 = solution.findRange(arr6, key6);

        // Assert
        CollectionAssert.AreEqual(expected1, result1, "Test Case 1 failed");
        CollectionAssert.AreEqual(expected2, result2, "Test Case 2 failed");
        CollectionAssert.AreEqual(expected3, result3, "Test Case 3 failed");
        CollectionAssert.AreEqual(expected4, result4, "Test Case 4 failed");
        CollectionAssert.AreEqual(expected5, result5, "Test Case 5 failed");
        CollectionAssert.AreEqual(expected6, result6, "Test Case 6 failed");
    }

    [TestMethod]
    public void Test_SearchInfinityArray()
    {
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.Solution solution = new();
        // Test Case 1: Key present in array
        int[] arr1 = { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.ArrayReader reader1 = new(arr1);
        int key1 = 16;
        int expected1 = 6;

        // Test Case 2: Key not present in array
        int[] arr2 = { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.ArrayReader reader2 = new(arr2);
        int key2 = 11;
        int expected2 = -1;

        // Test Case 3: Key at end of array
        int[] arr3 = { 1, 3, 8, 10, 15 };
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.ArrayReader reader3 = new(arr3);
        int key3 = 15;
        int expected3 = 4;

        // Test Case 4: Key beyond array bounds
        int[] arr4 = { 1, 3, 8, 10, 15 };
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.ArrayReader reader4 = new(arr4);
        int key4 = 200;
        int expected4 = -1;

        // Test Case 5: Empty array
        int[] arr5 = { };
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.ArrayReader reader5 = new(arr5);
        int key5 = 5;
        int expected5 = -1;

        // Test Case 6: Single element array, key present
        int[] arr6 = { 1 };
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.ArrayReader reader6 = new(arr6);
        int key6 = 1;
        int expected6 = 0;

        // Test Case 7: Single element array, key not present
        int[] arr7 = { 1 };
        Programming.Patterns.ModifiedBinarySearch.SearchInfinityArray.ArrayReader reader7 = new(arr7);
        int key7 = 2;
        int expected7 = -1;

        // Act
        int result1 = solution.searchInfiniteSortedArray(reader1, key1);
        int result2 = solution.searchInfiniteSortedArray(reader2, key2);
        int result3 = solution.searchInfiniteSortedArray(reader3, key3);
        int result4 = solution.searchInfiniteSortedArray(reader4, key4);
        int result5 = solution.searchInfiniteSortedArray(reader5, key5);
        int result6 = solution.searchInfiniteSortedArray(reader6, key6);
        int result7 = solution.searchInfiniteSortedArray(reader7, key7);

        // Assert
        Assert.AreEqual(expected1, result1, "Test Case 1 failed");
        Assert.AreEqual(expected2, result2, "Test Case 2 failed");
        Assert.AreEqual(expected3, result3, "Test Case 3 failed");
        Assert.AreEqual(expected4, result4, "Test Case 4 failed");
        Assert.AreEqual(expected5, result5, "Test Case 5 failed");
        Assert.AreEqual(expected6, result6, "Test Case 6 failed");
        Assert.AreEqual(expected7, result7, "Test Case 7 failed");
    }

    [TestMethod]
    public void Test_FindMissingNumber()
    {
        Programming.Patterns.BitwiseXOR.FindMissingNumber.Solution solution = new();

        // Test case 1: Array [1,2,4,5], missing 3
        int[] arr1 = { 1, 2, 4, 5 };
        int result1 = solution.findMissingNumber(arr1);
        Assert.AreEqual(3, result1, "Missing number should be 3 for input [1,2,4,5]");

        // Test case 2: Array [2,3,4,5], missing 1
        int[] arr2 = { 2, 3, 4, 5 };
        int result2 = solution.findMissingNumber(arr2);
        Assert.AreEqual(1, result2, "Missing number should be 1 for input [2,3,4,5]");

        // Test case 3: Array [1,2,3,4], missing 5
        int[] arr3 = { 1, 2, 3, 4 };
        int result3 = solution.findMissingNumber(arr3);
        Assert.AreEqual(5, result3, "Missing number should be 5 for input [1,2,3,4]");

        // Test case 4: Single element [1], missing 2
        int[] arr4 = { 1 };
        int result4 = solution.findMissingNumber(arr4);
        Assert.AreEqual(2, result4, "Missing number should be 2 for input [1]");

        // Test case 5: Larger array [1,2,3,4,5,6,8,9,10], missing 7
        int[] arr5 = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
        int result5 = solution.findMissingNumber(arr5);
        Assert.AreEqual(7, result5, "Missing number should be 7 for input [1,2,3,4,5,6,8,9,10]");
    }

    [TestMethod]
    public void Test_FindSingleNumber()
    {
        Programming.Patterns.BitwiseXOR.SingleNumber.Solution solution = new();
        // Test Case 1: Example from problem statement
        int[] arr1 = { 1, 4, 2, 1, 3, 2, 3 };
        int expected1 = 4;

        // Test Case 2: Example from problem statement
        int[] arr2 = { 7, 9, 7 };
        int expected2 = 9;

        // Test Case 3: Single element array
        int[] arr3 = { 5 };
        int expected3 = 5;

        // Test Case 4: Larger array with negative numbers
        int[] arr4 = { -1, 2, -1, 3, 2, 4, 4 };
        int expected4 = 3;

        // Test Case 5: Array with maximum constraint values
        int[] arr5 = { 30000, 1, 30000, 2, 2 };
        int expected5 = 1;

        // Act
        int result1 = solution.findSingleNumber(arr1);
        int result2 = solution.findSingleNumber(arr2);
        int result3 = solution.findSingleNumber(arr3);
        int result4 = solution.findSingleNumber(arr4);
        int result5 = solution.findSingleNumber(arr5);

        // Assert
        Assert.AreEqual(expected1, result1, "Test Case 1 failed");
        Assert.AreEqual(expected2, result2, "Test Case 2 failed");
        Assert.AreEqual(expected3, result3, "Test Case 3 failed");
        Assert.AreEqual(expected4, result4, "Test Case 4 failed");
        Assert.AreEqual(expected5, result5, "Test Case 5 failed");
    }

    [TestMethod]
    public void Test_FindwoSingleNumbers()
    {
        Programming.Patterns.BitwiseXOR.TwoSingleNumbers.Solution solution = new();
        // Test Case 1: Example from problem statement
        int[] arr1 = { 1, 4, 2, 1, 3, 5, 6, 2, 3, 5 };
        int[] expected1 = { 4, 6 };

        // Test Case 2: Example from problem statement
        int[] arr2 = { 2, 1, 3, 2 };
        int[] expected2 = { 1, 3 };

        // Test Case 3: Minimum length array
        int[] arr3 = { 1, 1, 2, 3 };
        int[] expected3 = { 2, 3 };

        // Test Case 4: Array with negative numbers
        int[] arr4 = { -1, -1, 2, -3, 2, -4 };
        int[] expected4 = { -3, -4 };

        // Test Case 5: Array with maximum constraint values
        int[] arr5 = { 30000, 1, 30000, 2, 2, -30000 };
        int[] expected5 = { 1, -30000 };

        // Act
        int[] result1 = solution.findSingleNumbers(arr1);
        int[] result2 = solution.findSingleNumbers(arr2);
        int[] result3 = solution.findSingleNumbers(arr3);
        int[] result4 = solution.findSingleNumbers(arr4);
        int[] result5 = solution.findSingleNumbers(arr5);

        // Assert
        CollectionAssert.AreEquivalent(expected1, result1, "Test Case 1 failed");
        CollectionAssert.AreEquivalent(expected2, result2, "Test Case 2 failed");
        CollectionAssert.AreEquivalent(expected3, result3, "Test Case 3 failed");
        CollectionAssert.AreEquivalent(expected4, result4, "Test Case 4 failed");
        CollectionAssert.AreEquivalent(expected5, result5, "Test Case 5 failed");
    }

    [TestMethod]
    public void Test_ComplementOfBase10()
    {
        Programming.Patterns.BitwiseXOR.ComplementOfBase10.Solution solution = new();
        // Test Case 1: Example from problem statement
        int num1 = 8;
        int expected1 = 7;

        // Test Case 2: Example from problem statement
        int num2 = 10;
        int expected2 = 5;

        // Test Case 3: Small number
        int num3 = 1;
        int expected3 = 0;

        // Test Case 4: Number with all 1s in binary
        int num4 = 7; // 111 in binary
        int expected4 = 0; // 000 in binary

        // Test Case 5: Larger number
        int num5 = 100;
        int expected5 = 27; // 100 is 1100100, complement is 0011011 which is 27

        int num6 = 999999999; // Close to 10^9
        int expected6 = 73741824; // Complement of 999999999 
        // (111011100110101100100111111111) is 
        // (000100011001010011011000000000)

        // Act
        int result1 = solution.bitwiseComplement(num1);
        int result2 = solution.bitwiseComplement(num2);
        int result3 = solution.bitwiseComplement(num3);
        int result4 = solution.bitwiseComplement(num4);
        int result5 = solution.bitwiseComplement(num5);
        int result6 = solution.bitwiseComplement(num6);

        // Assert
        Assert.AreEqual(expected1, result1, "Test Case 1 failed");
        Assert.AreEqual(expected2, result2, "Test Case 2 failed");
        Assert.AreEqual(expected3, result3, "Test Case 3 failed");
        Assert.AreEqual(expected4, result4, "Test Case 4 failed");
        Assert.AreEqual(expected5, result5, "Test Case 5 failed");
        Assert.AreEqual(expected6, result6, "Test Case 6 failed");
    }

    [TestMethod]
    public void Test_TopKElements()
    {
        Programming.Patterns.TopKElements.TopK.Solution solution = new();
        // Test Case 1: Example from problem statement
        int[] arr1 = { 3, 1, 5, 12, 2, 11 };
        int k1 = 3;
        List<int> expected1 = new List<int> { 5, 12, 11 };

        // Test Case 2: Example from problem statement with duplicates
        int[] arr2 = { 5, 12, 11, -1, 12 };
        int k2 = 3;
        List<int> expected2 = new List<int> { 12, 11, 12 };

        // Test Case 3: Single element array
        int[] arr3 = { 1 };
        int k3 = 1;
        List<int> expected3 = new List<int> { 1 };

        // Test Case 4: Array with negative numbers
        int[] arr4 = { -2, -5, 0, -1, -3 };
        int k4 = 2;
        List<int> expected4 = new List<int> { 0, -1 };

        // Test Case 5: Array with all identical elements
        int[] arr5 = { 7, 7, 7, 7 };
        int k5 = 3;
        List<int> expected5 = new List<int> { 7, 7, 7 };

        // Test Case 6: Maximum constraint values
        int[] arr6 = { 100000, 50000, -100000, 75000, 25000 };
        int k6 = 3;
        List<int> expected6 = new List<int> { 100000, 75000, 50000 };

        // Act
        List<int> result1 = solution.findKLargestNumbers(arr1, k1);
        List<int> result2 = solution.findKLargestNumbers(arr2, k2);
        List<int> result3 = solution.findKLargestNumbers(arr3, k3);
        List<int> result4 = solution.findKLargestNumbers(arr4, k4);
        List<int> result5 = solution.findKLargestNumbers(arr5, k5);
        List<int> result6 = solution.findKLargestNumbers(arr6, k6);

        // Assert
        CollectionAssert.AreEquivalent(expected1, result1, "Test Case 1 failed");
        CollectionAssert.AreEquivalent(expected2, result2, "Test Case 2 failed");
        CollectionAssert.AreEquivalent(expected3, result3, "Test Case 3 failed");
        CollectionAssert.AreEquivalent(expected4, result4, "Test Case 4 failed");
        CollectionAssert.AreEquivalent(expected5, result5, "Test Case 5 failed");
        CollectionAssert.AreEquivalent(expected6, result6, "Test Case 6 failed");
    }

    [DataTestMethod]
    [DataRow(new int[] { 1, 5, 12, 2, 11, 5 }, 3, 5, "Example 1: 3rd smallest is 5")]
    [DataRow(new int[] { 1, 5, 12, 2, 11, 5 }, 4, 5, "Example 2: 4th smallest is 5")]
    [DataRow(new int[] { 5, 12, 11, -1, 12 }, 3, 11, "Example 3: 3rd smallest is 11")]
    [DataRow(new int[] { 1 }, 1, 1, "Single element array")]
    [DataRow(new int[] { 3, 1, 4, 2 }, 4, 4, "k equals array length")]
    [DataRow(new int[] { 7, 7, 7, 7 }, 3, 7, "All elements identical")]
    [DataRow(new int[] { -4, -2, -1, -3 }, 2, -3, "Negative numbers only")]
    [DataRow(new int[] { }, 1, 0, "Empty array", true)]
    [DataRow(null, 1, 0, "Null array", true)]
    [DataRow(new int[] { 1, 2, 3 }, 0, 0, "k <= 0", true)]
    [DataRow(new int[] { 1, 2, 3 }, 4, 0, "k > nums.length", true)]
    [DataRow(new int[] { 100, 50, 25, 75, 10, 90, 30, 60 }, 2, 25, "Large array, small k")]
    [DataRow(new int[] { 100, 50, 25, 75, 10, 90, 30, 60 }, 7, 90, "Large array, large k")]
    [DataRow(new int[] { 10000, -10000, 0, 5000, -5000 }, 3, 0, "Max/min values")]
    [DataRow(new int[] { 2, 2, 2, 1, 1, 3, 3 }, 5, 2, "Many duplicates")]
    [DataRow(new int[] { 10, -5, 0, 3, -2, 8 }, 4, 3, "Mixed positive/negative")]
    public void Test_FindKthSmallestNumber(int[] nums, int k, int expected, string description, bool expectException = false)
    {
        Programming.Patterns.TopKElements.KthSmallest.Solution solution = new();

        if (expectException)
        {
            Assert.ThrowsException<ArgumentException>(() => solution.findKthSmallestNumber(nums, k), description);
        }
        else
        {
            int result = solution.findKthSmallestNumber(nums, k);
            Assert.AreEqual(expected, result, description);
        }
    }

    [TestMethod]
    public void Test_ConnectRopes()
    {
        Programming.Patterns.TopKElements.ConnectRope.Solution solution = new();
        // Test Case 1: Example from problem statement
        int[] ropes1 = { 1, 3, 11, 5 };
        int expected1 = 33;

        // Test Case 2: Example from problem statement
        int[] ropes2 = { 3, 4, 5, 6 };
        int expected2 = 36;

        // Test Case 3: Example from problem statement
        int[] ropes3 = { 1, 3, 11, 5, 2 };
        int expected3 = 42;

        // Test Case 4: Single rope
        int[] ropes4 = { 5 };
        int expected4 = 0;

        // Test Case 5: Two ropes
        int[] ropes5 = { 2, 3 };
        int expected5 = 5;

        // Test Case 6: Array with maximum constraint values
        int[] ropes6 = { 10000, 10000, 10000 };
        int expected6 = 50000;

        // Act
        int result1 = solution.minimumCostToConnectRopes(ropes1);
        int result2 = solution.minimumCostToConnectRopes(ropes2);
        int result3 = solution.minimumCostToConnectRopes(ropes3);
        int result4 = solution.minimumCostToConnectRopes(ropes4);
        int result5 = solution.minimumCostToConnectRopes(ropes5);
        int result6 = solution.minimumCostToConnectRopes(ropes6);

        // Assert
        Assert.AreEqual(expected1, result1, "Test Case 1 failed");
        Assert.AreEqual(expected2, result2, "Test Case 2 failed");
        Assert.AreEqual(expected3, result3, "Test Case 3 failed");
        Assert.AreEqual(expected4, result4, "Test Case 4 failed");
        Assert.AreEqual(expected5, result5, "Test Case 5 failed");
        Assert.AreEqual(expected6, result6, "Test Case 6 failed");
    }

    public void Test_TopKFreqency()
    {
        Programming.Patterns.TopKElements.TopKFreqency.Solution solution = new();
        // Test Case 1: Example from problem statement
        int[] arr1 = { 1, 3, 5, 12, 11, 12, 11 };
        int k1 = 2;
        List<int> expected1 = new List<int> { 12, 11 };

        // Test Case 2: Example from problem statement
        int[] arr2 = { 5, 12, 11, 3, 11 };
        int k2 = 2;
        List<int> expected2 = new List<int> { 11, 5 }; // 11 appears twice, others once

        // Test Case 3: Single element array
        int[] arr3 = { 1 };
        int k3 = 1;
        List<int> expected3 = new List<int> { 1 };

        // Test Case 4: Array with all elements having same frequency
        int[] arr4 = { 1, 2, 3, 4 };
        int k4 = 2;
        List<int> expected4 = new List<int> { 1, 2 }; // Any two numbers are valid

        // Test Case 5: Array with negative numbers
        int[] arr5 = { -1, -1, -2, -2, -3 };
        int k5 = 2;
        List<int> expected5 = new List<int> { -1, -2 };

        // Test Case 6: Maximum constraint values
        int[] arr6 = { 100000, 100000, -100000, -100000, 50000 };
        int k6 = 2;
        List<int> expected6 = new List<int> { 100000, -100000 };

        // Act
        List<int> result1 = solution.findTopKFrequentNumbers(arr1, k1);
        List<int> result2 = solution.findTopKFrequentNumbers(arr2, k2);
        List<int> result3 = solution.findTopKFrequentNumbers(arr3, k3);
        List<int> result4 = solution.findTopKFrequentNumbers(arr4, k4);
        List<int> result5 = solution.findTopKFrequentNumbers(arr5, k5);
        List<int> result6 = solution.findTopKFrequentNumbers(arr6, k6);

        // Assert
        CollectionAssert.AreEquivalent(expected1, result1, "Test Case 1 failed");
        CollectionAssert.AreEquivalent(expected2, result2, "Test Case 2 failed");
        CollectionAssert.AreEquivalent(expected3, result3, "Test Case 3 failed");
        CollectionAssert.AreEquivalent(expected4, result4, "Test Case 4 failed");
        CollectionAssert.AreEquivalent(expected5, result5, "Test Case 5 failed");
        CollectionAssert.AreEquivalent(expected6, result6, "Test Case 6 failed");
    }
}
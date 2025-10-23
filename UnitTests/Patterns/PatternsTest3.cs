
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

    [TestMethod]
    public void Test_BoatsToSavePeople()
    {
        Programming.Patterns.Greedy.BoatToSavePeople.Solution solution = new();
        // Test Case 1: Example from problem - people=[10,55,70,20,90,85], limit=100
        // Expected: 4
        int[] people1 = new int[] { 10, 55, 70, 20, 90, 85 };
        int limit1 = 100;
        int result1 = solution.numRescueBoats(people1, limit1);
        Assert.AreEqual(4, result1, "Test Case 1: Minimum boats for people=[10,55,70,20,90,85], limit=100 should be 4");

        // Test Case 2: Single person with weight equal to limit
        // Expected: 1
        int[] people2 = new int[] { 50 };
        int limit2 = 50;
        int result2 = solution.numRescueBoats(people2, limit2);
        Assert.AreEqual(1, result2, "Test Case 2: Minimum boats for people=[50], limit=50 should be 1");

        // Test Case 3: All people with weight equal to limit (no pairing possible)
        // Expected: 3
        int[] people3 = new int[] { 100, 100, 100 };
        int limit3 = 100;
        int result3 = solution.numRescueBoats(people3, limit3);
        Assert.AreEqual(3, result3, "Test Case 3: Minimum boats for people=[100,100,100], limit=100 should be 3");

        // Test Case 4: People with weights allowing maximum pairing
        // Expected: 2
        int[] people4 = new int[] { 10, 20, 30, 40 };
        int limit4 = 60;
        int result4 = solution.numRescueBoats(people4, limit4);
        Assert.AreEqual(2, result4, "Test Case 4: Minimum boats for people=[10,20,30,40], limit=60 should be 2 (pairs: 10+40, 20+30)");

        // Test Case 5: Single person with weight less than limit
        // Expected: 1
        int[] people5 = new int[] { 30 };
        int limit5 = 100;
        int result5 = solution.numRescueBoats(people5, limit5);
        Assert.AreEqual(1, result5, "Test Case 5: Minimum boats for people=[30], limit=100 should be 1");

        // Test Case 6: All people with minimum weight, maximum pairing
        // Expected: 2
        int[] people6 = new int[] { 1, 1, 1, 1 };
        int limit6 = 2;
        int result6 = solution.numRescueBoats(people6, limit6);
        Assert.AreEqual(2, result6, "Test Case 6: Minimum boats for people=[1,1,1,1], limit=2 should be 2 (pairs: 1+1, 1+1)");
    }

    [TestMethod]
    public void Test_ValidPalindromeII()
    {
        Programming.Patterns.Greedy.ValidPalindromeII.Solution solution = new();
        // Test Case 1: Example 1 - s="racecar"
        // Expected: true (already a palindrome)
        string s1 = "racecar";
        bool result1 = solution.isPalindromePossible(s1);
        Assert.IsTrue(result1, "Test Case 1: 'racecar' is already a palindrome, should return true");

        // Test Case 2: Example 2 - s="abccdba"
        // Expected: true (remove 'd' to form "abccba")
        string s2 = "abccdba";
        bool result2 = solution.isPalindromePossible(s2);
        Assert.IsTrue(result2, "Test Case 2: 'abccdba' can be palindrome by removing 'd', should return true");

        // Test Case 3: Example 3 - s="abcdef"
        // Expected: false (no single removal makes it a palindrome)
        string s3 = "abcdef";
        bool result3 = solution.isPalindromePossible(s3);
        Assert.IsFalse(result3, "Test Case 3: 'abcdef' cannot be a palindrome with one removal, should return false");

        // Test Case 4: Single character
        // Expected: true (single character is always a palindrome)
        string s4 = "a";
        bool result4 = solution.isPalindromePossible(s4);
        Assert.IsTrue(result4, "Test Case 4: Single character 'a' is a palindrome, should return true");

        // Test Case 5: Two characters, not equal
        // Expected: true (remove one to make a single-character palindrome)
        string s5 = "ab";
        bool result5 = solution.isPalindromePossible(s5);
        Assert.IsTrue(result5, "Test Case 5: 'ab' can be a palindrome by removing one character, should return true");

        // Test Case 6: Long string requiring one removal
        string s6 = "aabbccde";
        bool result6 = solution.isPalindromePossible(s6);
        Assert.IsFalse(result6);

        // Test Case 7: Long string where no single removal works
        // Expected: false
        string s7 = "abcde";
        bool result7 = solution.isPalindromePossible(s7);
        Assert.IsFalse(result7, "Test Case 7: 'abcde' cannot be a palindrome with one removal, should return false");
    }

    [TestMethod]
    public void Test_MaxLengthOfPairChain()
    {
        Programming.Patterns.Greedy.MaxLengthOfPairChain.Solution solution = new();
        // Test Case 1: Example 1 - pairs=[[1,2], [3,4], [2,3]]
        // Expected: 2 ([1,2] -> [3,4])
        int[][] pairs1 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 2, 3 } };
        int result1 = solution.findLongestChain(pairs1);
        Assert.AreEqual(2, result1, "Test Case 1: Maximum chain length for [[1,2], [3,4], [2,3]] should be 2");

        // Test Case 2: Example 2 - pairs=[[5,6], [1,2], [8,9], [2,3]]
        // Expected: 3 ([1,2] -> [5,6] -> [8,9])
        int[][] pairs2 = new int[][] { new int[] { 5, 6 }, new int[] { 1, 2 }, new int[] { 8, 9 }, new int[] { 2, 3 } };
        int result2 = solution.findLongestChain(pairs2);
        Assert.AreEqual(3, result2, "Test Case 2: Maximum chain length for [[5,6], [1,2], [8,9], [2,3]] should be 3");

        // Test Case 3: Example 3 - pairs=[[7,8], [5,6], [1,2], [3,5], [4,5], [2,3]]
        // Expected: 3 ([1,2] -> [3,5] -> [7,8])
        int[][] pairs3 = new int[][] { new int[] { 7, 8 }, new int[] { 5, 6 }, new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 4, 5 }, new int[] { 2, 3 } };
        int result3 = solution.findLongestChain(pairs3);
        Assert.AreEqual(3, result3, "Test Case 3: Maximum chain length for [[7,8], [5,6], [1,2], [3,5], [4,5], [2,3]] should be 3");

        // Test Case 4: Single pair
        // Expected: 1
        int[][] pairs4 = new int[][] { new int[] { 1, 2 } };
        int result4 = solution.findLongestChain(pairs4);
        Assert.AreEqual(1, result4, "Test Case 4: Maximum chain length for [[1,2]] should be 1");

        // Test Case 5: Pairs with negative values
        // Expected: 2 ([-2,0] -> [1,2])
        int[][] pairs5 = new int[][] { new int[] { -2, 0 }, new int[] { 1, 2 }, new int[] { -3, -1 } };
        int result5 = solution.findLongestChain(pairs5);
        Assert.AreEqual(2, result5, "Test Case 5: Maximum chain length for [[-2,0], [1,2], [-3,-1]] should be 2");

        // Test Case 6: No valid chain longer than 1
        // Expected: 1 (no pair has b < c for any other pair)
        int[][] pairs6 = new int[][] { new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 3, 5 } };
        int result6 = solution.findLongestChain(pairs6);
        Assert.AreEqual(1, result6, "Test Case 6: Maximum chain length for [[1,3], [2,4], [3,5]] should be 1");
    }

    [TestMethod]
    public void Test_MinimumParenthesesAddedToMakeValid()
    {
        Programming.Patterns.Greedy.MinimumParenthese.Solution solution = new();
        // Test Case 1: Example 1 - s="(()"
        // Expected: 1 (add one closing parenthesis)
        string s1 = "(()";
        int result1 = solution.minAddToMakeValid(s1);
        Assert.AreEqual(1, result1, "Test Case 1: Minimum additions for '(()' should be 1");

        // Test Case 2: Example 2 - s="))(("
        // Expected: 4 (add two opening and two closing parentheses)
        string s2 = "))((";
        int result2 = solution.minAddToMakeValid(s2);
        Assert.AreEqual(4, result2, "Test Case 2: Minimum additions for '))((' should be 4");

        // Test Case 3: Example 3 - s="(()())("
        // Expected: 1 (add one closing parenthesis)
        string s3 = "(()())(";
        int result3 = solution.minAddToMakeValid(s3);
        Assert.AreEqual(1, result3, "Test Case 3: Minimum additions for '(()())(' should be 1");

        // Test Case 4: Empty string
        // Expected: 0 (already valid)
        string s4 = "";
        int result4 = solution.minAddToMakeValid(s4);
        Assert.AreEqual(0, result4, "Test Case 4: Minimum additions for empty string should be 0");

        // Test Case 5: Single opening parenthesis
        // Expected: 1 (add one closing parenthesis)
        string s5 = "(";
        int result5 = solution.minAddToMakeValid(s5);
        Assert.AreEqual(1, result5, "Test Case 5: Minimum additions for '(' should be 1");

        // Test Case 6: Single closing parenthesis
        // Expected: 1 (add one opening parenthesis)
        string s6 = ")";
        int result6 = solution.minAddToMakeValid(s6);
        Assert.AreEqual(1, result6, "Test Case 6: Minimum additions for ')' should be 1");

        // Test Case 7: Already valid string
        // Expected: 0 (no additions needed)
        string s7 = "()()";
        int result7 = solution.minAddToMakeValid(s7);
        Assert.AreEqual(0, result7, "Test Case 7: Minimum additions for '()()' should be 0");

        // Test Case 8: Complex unbalanced string
        // Expected: 2 (add two parentheses to balance)
        string s8 = "())(";
        int result8 = solution.minAddToMakeValid(s8);
        Assert.AreEqual(2, result8, "Test Case 8: Minimum additions for '())(' should be 3");
    }

    [TestMethod]
    public void Test_EqualSubsetSumPartition()
    {
        Programming.Patterns.Knapsack.EqualSubsetSumPartition.Solution solution = new();
        // Test Case 1: Example 1 - num=[1,2,3,4]
        // Expected: True (subsets: {1,4} and {2,3}, both sum to 5)
        int[] num1 = new int[] { 1, 2, 3, 4 };
        bool result1 = solution.canPartition(num1);
        Assert.IsTrue(result1, "Test Case 1: Array [1,2,3,4] should be partitionable into equal sum subsets");

        // Test Case 2: Example 2 - num=[1,1,3,4,7]
        // Expected: True (subsets: {1,3,4} and {1,7}, both sum to 8)
        int[] num2 = new int[] { 1, 1, 3, 4, 7 };
        bool result2 = solution.canPartition(num2);
        Assert.IsTrue(result2, "Test Case 2: Array [1,1,3,4,7] should be partitionable into equal sum subsets");

        // Test Case 3: Example 3 - num=[2,3,4,6]
        // Expected: False (sum=15, cannot partition into two equal sums)
        int[] num3 = new int[] { 2, 3, 4, 6 };
        bool result3 = solution.canPartition(num3);
        Assert.IsFalse(result3, "Test Case 3: Array [2,3,4,6] cannot be partitioned into equal sum subsets");

        // Test Case 4: Single element
        // Expected: False (cannot partition one element into two non-empty subsets)
        int[] num4 = new int[] { 1 };
        bool result4 = solution.canPartition(num4);
        Assert.IsFalse(result4, "Test Case 4: Array [1] cannot be partitioned into equal sum subsets");

        // Test Case 5: Two equal elements
        // Expected: True (subsets: {1} and {1}, both sum to 1)
        int[] num5 = new int[] { 1, 1 };
        bool result5 = solution.canPartition(num5);
        Assert.IsTrue(result5, "Test Case 5: Array [1,1] should be partitionable into equal sum subsets");

        // Test Case 6: Array with odd total sum
        // Expected: False (sum=7, cannot partition into two equal sums)
        int[] num6 = new int[] { 2, 2, 3 };
        bool result6 = solution.canPartition(num6);
        Assert.IsFalse(result6, "Test Case 6: Array [2,2,3] cannot be partitioned into equal sum subsets");

        // Test Case 7: Array with maximum values
        // Expected: True (subsets: {100,100} and {100,100}, both sum to 200)
        int[] num7 = new int[] { 100, 100, 100, 100 };
        bool result7 = solution.canPartition(num7);
        Assert.IsTrue(result7, "Test Case 7: Array [100,100,100,100] should be partitionable into equal sum subsets");
    }

    [TestMethod]
    public void Test_FibonacciNumbers()
    {
        Programming.Patterns.FibonacciNumbers.Dp.Solution solution = new();
        Assert.AreEqual(2, solution.calculateFibonacci(3));
        Assert.AreEqual(3, solution.calculateFibonacci(4));
    }

    [TestMethod]
    public void Test_LongestPalindromeSubSequence()
    {
        var solution = new Programming.Patterns.Palindromic.LongestPalindromicSubsequence.Solution();

        // --- Provided Examples ---
        Assert.AreEqual(5, solution.findLPSLength("abdbca"));   // "abdba"
        Assert.AreEqual(3, solution.findLPSLength("cddpd"));    // "ddd"
        Assert.AreEqual(1, solution.findLPSLength("pqr"));      // "p" or "q" or "r"

        // --- Additional Edge Cases ---
        // Single character (minimum length per constraints)
        Assert.AreEqual(1, solution.findLPSLength("a"));

        // All same characters -> whole string is palindromic
        Assert.AreEqual(5, solution.findLPSLength("aaaaa"));

        // Already a palindrome -> LPS is the entire string
        Assert.AreEqual(7, solution.findLPSLength("racecar"));

        // Two different characters -> any single char is the LPS
        Assert.AreEqual(1, solution.findLPSLength("ab"));

        // Classic mixed case with multiple options; known LPS length is 4 ("bbbb")
        Assert.AreEqual(4, solution.findLPSLength("bbbab"));
    }

    private static void AssertListsEqual(List<List<int>> actual, List<List<int>> expected, string message)
    {
        // Convert lists to sorted strings for comparison
        var actualSet = actual.Select(list => string.Join(",", list.OrderBy(x => x))).OrderBy(s => s).ToList();
        var expectedSet = expected.Select(list => string.Join(",", list.OrderBy(x => x))).OrderBy(s => s).ToList();
        CollectionAssert.AreEqual(expectedSet, actualSet, message);
    }

    [TestMethod]
    public void Test_Backtracking_CombinationSum()
    {
        Programming.Patterns.Backtracking.CombinationSum.Solution solution = new();

        // Test Case 1: Example 1 - candidates=[2,3,6,7], target=7
        // Expected: [[2,2,3], [7]]
        int[] candidates1 = [2, 3, 6, 7];
        int target1 = 7;
        List<List<int>> expected1 =
        [
        [2, 2, 3],
        [7]];
        List<List<int>> result1 = solution.combinationSum(candidates1, target1);
        AssertListsEqual(result1, expected1, "Test Case 1: Combinations for candidates=[2,3,6,7], target=7 should be [[2,2,3], [7]]");

        // Test Case 2: Example 2 - candidates=[2,4,6,8], target=10
        // Expected: [[2,2,2,2,2], [2,2,2,4], [2,2,6], [2,4,4], [2,8], [4,6]]
        int[] candidates2 = [2, 4, 6, 8];
        int target2 = 10;
        List<List<int>> expected2 =
    [
        [2, 2, 2, 2, 2],
        [2, 2, 2, 4],
        [2, 2, 6],
        [2, 4, 4],
        [2, 8],
        [4, 6]
    ];
        List<List<int>> result2 = solution.combinationSum(candidates2, target2);
        AssertListsEqual(result2, expected2, "Test Case 2: Combinations for candidates=[2,4,6,8], target=10 should be [[2,2,2,2,2], [2,2,2,4], [2,2,6], [2,4,4], [2,8], [4,6]]");

        // Test Case 3: Single candidate, target equals candidate
        // Expected: [[2]]
        int[] candidates3 = [2];
        int target3 = 2;
        List<List<int>> expected3 =
    [
        [2]
    ];
        List<List<int>> result3 = solution.combinationSum(candidates3, target3);
        AssertListsEqual(result3, expected3, "Test Case 3: Combinations for candidates=[2], target=2 should be [[2]]");

        // Test Case 4: No valid combinations
        // Expected: [] (empty list)
        int[] candidates4 = [3, 5, 7];
        int target4 = 2;
        List<List<int>> expected4 = new List<List<int>> { };
        List<List<int>> result4 = solution.combinationSum(candidates4, target4);
        AssertListsEqual(result4, expected4, "Test Case 4: Combinations for candidates=[3,5,7], target=2 should be []");

        // Test Case 5: Single candidate, multiple uses
        // Expected: [[2,2,2]]
        int[] candidates5 = [2];
        int target5 = 6;
        List<List<int>> expected5 =
    [
        [2, 2, 2]
    ];
        List<List<int>> result5 = solution.combinationSum(candidates5, target5);
        AssertListsEqual(result5, expected5, "Test Case 5: Combinations for candidates=[2], target=6 should be [[2,2,2]]");

        // Test Case 6: Large target with multiple candidates
        // Expected: [[2,2,2,2], [2,3,3]]
        int[] candidates6 = new int[] { 2, 3 };
        int target6 = 8;
        List<List<int>> expected6 =
    [
        [2, 2, 2, 2],
        [2, 3, 3]
    ];
        List<List<int>> result6 = solution.combinationSum(candidates6, target6);
        AssertListsEqual(result6, expected6, "Test Case 6: Combinations for candidates=[2,3], target=8 should be [[2,2,2,2], [2,3,3]]");
    }
}
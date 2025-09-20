
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
        Programming.Patterns.Greedy.Solution solution = new();
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
}
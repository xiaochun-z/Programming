using System.Net;

namespace UnitTests;


[TestClass]
public sealed class Patterns_Tests
{
    [TestMethod]
    public void Test_ReverseVowel()
    {
        var solution = new Programming.Patterns.ReverseVowels.Solution();
        // Basic examples from problem statement
        Assert.AreEqual("holle", solution.reverseVowels("hello"));        // normal case
        Assert.AreEqual("leotcede", solution.reverseVowels("leetcode"));  // multiple vowels
        Assert.AreEqual("aA", solution.reverseVowels("Aa"));              // case sensitivity
        Assert.AreEqual("", solution.reverseVowels(""));                  // empty string

        // Single character cases
        Assert.AreEqual("b", solution.reverseVowels("b"));   // single consonant
        Assert.AreEqual("a", solution.reverseVowels("a"));   // single vowel
        Assert.AreEqual("A", solution.reverseVowels("A"));   // single uppercase vowel

        // No vowels
        Assert.AreEqual("bcdfg", solution.reverseVowels("bcdfg"));  // all consonants
        Assert.AreEqual("xyz", solution.reverseVowels("xyz"));      // no vowels at all

        // All vowels
        Assert.AreEqual("uoiea", solution.reverseVowels("aeiou"));  // reverse all lowercase vowels
        Assert.AreEqual("UOIEA", solution.reverseVowels("AEIOU"));  // reverse all uppercase vowels

        // Mixed case
        Assert.AreEqual("HEllO", solution.reverseVowels("HOllE"));  // mixed upper/lower vowels reversed
        Assert.AreEqual("JAkO", solution.reverseVowels("JOkA"));    // short mixed-case word

        // With numbers and symbols
        Assert.AreEqual("t3st!ng", solution.reverseVowels("t3st!ng"));     // no vowels, string unchanged
        Assert.AreEqual("c0d1ng!", solution.reverseVowels("c0d1ng!"));     // no vowels, string unchanged
        Assert.AreEqual("h1ll0!", solution.reverseVowels("h1ll0!"));       // no vowels, string unchanged
        Assert.AreEqual("t2stE!ngI", solution.reverseVowels("t2stI!ngE"));  // vowels reversed around digits/symbols

        // Long string (performance check)
        string input = new string('a', 1000) + "bc" + new string('e', 1000);
        string expected = new string('e', 1000) + "bc" + new string('a', 1000);
        Assert.AreEqual(expected, solution.reverseVowels(input));          // large string reversed

    }

    [TestMethod]
    public void Test_IsPalindrome()
    {
        var solution = new Programming.Patterns.Palindrome.Solution();

        // Basic examples
        Assert.IsTrue(solution.isPalindrome("A man, a plan, a canal: Panama"));
        Assert.IsFalse(solution.isPalindrome("race a car"));
        Assert.IsTrue(solution.isPalindrome(" "));
        Assert.IsTrue(solution.isPalindrome("A"));
        Assert.IsTrue(solution.isPalindrome("aa"));
        Assert.IsFalse(solution.isPalindrome("ab"));
        Assert.IsFalse(solution.isPalindrome("Not a palindrome"));
    }

    [TestMethod]
    public void Test_LinkedListCycle()
    {
        var head = new Programming.Patterns.FastAndSlowPointers.LinkedListCycle.ListNode(1)
        {
            Next = new Programming.Patterns.FastAndSlowPointers.LinkedListCycle.ListNode(2)
        };
        head.Next.Next = new Programming.Patterns.FastAndSlowPointers.LinkedListCycle.ListNode(3)
        {
            Next = new Programming.Patterns.FastAndSlowPointers.LinkedListCycle.ListNode(4)
        };
        head.Next.Next.Next.Next = new Programming.Patterns.FastAndSlowPointers.LinkedListCycle.ListNode(5)
        {
            Next = new Programming.Patterns.FastAndSlowPointers.LinkedListCycle.ListNode(6)
        };
        var solution = new Programming.Patterns.FastAndSlowPointers.LinkedListCycle.Solution();
        Assert.IsFalse(solution.hasCycle(head));

        head.Next.Next.Next.Next.Next.Next = head.Next.Next;     // Creating a cycle
        Assert.IsTrue(solution.hasCycle(head));

        head.Next.Next.Next.Next.Next.Next = head.Next.Next.Next; // Creating a longer cycle
        Assert.IsTrue(solution.hasCycle(head));
    }

    [TestMethod]
    public void Test_SlidingWindow_LongestKDistinct()
    {
        var solution = new Programming.Patterns.Slidingwindow.LongestKDisctinct.Solution();
        // Test case 1: Basic case with K=2
        var result1 = solution.findLength("araaci", 2);
        Assert.AreEqual(4, result1); // Explanation: Longest substring with at most 2 distinct characters is "araa"

        // Test case 2: Case where K=1
        var result2 = solution.findLength("araaci", 1);
        Assert.AreEqual(2, result2); // Explanation: Longest substring with at most 1 distinct character is "aa"

        // Test case 3: Case with K=3
        var result3 = solution.findLength("cbbebi", 3);
        Assert.AreEqual(5, result3); // Explanation: Longest substring with at most 3 distinct characters is "cbbeb" or "bbebi"

        // Test case 4: Case where the string has only one character
        var result4 = solution.findLength("aaaa", 1);
        Assert.AreEqual(4, result4); // Explanation: Longest substring with at most 1 distinct character is the whole string "aaaa"

        // Test case 5: Case where K is greater than the number of distinct characters in the string
        var result5 = solution.findLength("abcabc", 4);
        Assert.AreEqual(6, result5); // Explanation: Since K is greater than the distinct characters, the longest substring is the whole string "abcabc"

        // Test case 6: Case where the string is empty
        var result6 = solution.findLength("", 3);
        Assert.AreEqual(0, result6); // Explanation: No substring in an empty string

        // Test case 7: Case where K=0 (no distinct characters allowed)
        var result7 = solution.findLength("abcde", 0);
        Assert.AreEqual(0, result7); // Explanation: No valid substrings with 0 distinct characters

        // Test case 8: Case with the string having only one type of character
        var result8 = solution.findLength("aaaa", 3);
        Assert.AreEqual(4, result8); // Explanation: Longest substring with at most 3 distinct characters is the whole string "aaaa"

        // Test case 9: Case where K is 1 and the string has all unique characters
        var result9 = solution.findLength("abcdef", 1);
        Assert.AreEqual(1, result9); // Explanation: Longest substring with 1 distinct character is any single character, so the length is 1

        // Test case 10: Case with the string having alternating characters and K=2
        var result10 = solution.findLength("ababab", 2);
        Assert.AreEqual(6, result10); // Explanation: Longest substring with at most 2 distinct characters is "ababab"

        // Test case 11: Case where the string has K=50 (upper limit)
        var result11 = solution.findLength(new string('a', 50000), 50);
        Assert.AreEqual(50000, result11); // Explanation: The entire string contains only 1 distinct character, but since K=50, the length is 50000

    }

    [TestMethod]
    public void Test_MergeIntervals()
    {
        List<Programming.Patterns.MergeIntervals.MergeIntervals.Interval> input =
        [
            new Programming.Patterns.MergeIntervals.MergeIntervals.Interval(1, 4),
            new Programming.Patterns.MergeIntervals.MergeIntervals.Interval(2, 5),
            new Programming.Patterns.MergeIntervals.MergeIntervals.Interval(7, 9)
        ];

        Programming.Patterns.MergeIntervals.MergeIntervals.Solution solution = new();
        var result = solution.merge(input);

        List<Programming.Patterns.MergeIntervals.MergeIntervals.Interval> expect =
        [
            new Programming.Patterns.MergeIntervals.MergeIntervals.Interval(1, 5),
            new Programming.Patterns.MergeIntervals.MergeIntervals.Interval(7, 9)
        ];
        CollectionAssert.AreEqual(expect, result, new IntervalComparer2());
    }

    [TestMethod]
    public void Test_CyclicSort()
    {
        int[] arr = new int[] { 3, 1, 5, 4, 2 };
        Programming.Patterns.CycleSort.CycleSort.Solution solution = new();
        arr = solution.sort(arr); // Sort the array using the cyclic sort algorithm.
        int[] expect = [1, 2, 3, 4, 5];
        CollectionAssert.AreEqual(expect, arr);

        arr = [2, 6, 4, 3, 1, 5];
        arr = solution.sort(arr); // Sort another array using the cyclic sort algorithm.
        expect = [1, 2, 3, 4, 5, 6];
        CollectionAssert.AreEqual(expect, arr);

        arr = new int[] { 1, 5, 6, 4, 3, 2 };
        arr = solution.sort(arr); // Sort yet another array using the cyclic sort algorithm.
        CollectionAssert.AreEqual(expect, arr);
    }

    [TestMethod]
    public void Test_MissingNum()
    {
        Programming.Patterns.CycleSort.FindMissingNum.Solution solution = new();
        var result = solution.findMissingNumber([4, 0, 3, 1]);
        Assert.AreEqual(2, result);
        result = solution.findMissingNumber([8, 3, 5, 2, 4, 6, 0, 1]);
        Assert.AreEqual(7, result);
    }


    [TestMethod]
    public void Test_FindAllDuplicatedNumbers()
    {
        Programming.Patterns.CycleSort.FindDupNums.Solution solution = new();

        List<int> duplicates = solution.findNumbers([3, 4, 4, 5, 5]);
        List<int> expected = [4, 5];
        CollectionAssert.AreEqual(expected, duplicates);

        duplicates = solution.findNumbers([5, 4, 7, 2, 3, 5, 3]);
        expected = [3, 5];
        CollectionAssert.AreEqual(expected, duplicates);
    }
}

class IntervalComparer2 : System.Collections.IComparer
{
    public int Compare(object? a, object? b)
    {
        if (a == null || b == null) return -1;
        Programming.Patterns.MergeIntervals.MergeIntervals.Interval x = (Programming.Patterns.MergeIntervals.MergeIntervals.Interval)a;
        Programming.Patterns.MergeIntervals.MergeIntervals.Interval y = (Programming.Patterns.MergeIntervals.MergeIntervals.Interval)b;

        if (x.Start == y.Start && x.End == y.End)
        {
            return 0;
        }

        return -1;
    }
}
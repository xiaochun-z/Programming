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
}
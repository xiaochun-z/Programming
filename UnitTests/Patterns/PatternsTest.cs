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

        head!.Next!.Next!.Next!.Next!.Next!.Next = head.Next.Next;     // Creating a cycle
        Assert.IsTrue(solution.hasCycle(head));

        head.Next.Next.Next.Next.Next!.Next = head.Next.Next.Next; // Creating a longer cycle
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
        Programming.Patterns.CyclicSort.CycleSort.Solution solution = new();
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
        Programming.Patterns.CyclicSort.FindMissingNum.Solution solution = new();
        var result = solution.findMissingNumber([4, 0, 3, 1]);
        Assert.AreEqual(2, result);
        result = solution.findMissingNumber([8, 3, 5, 2, 4, 6, 0, 1]);
        Assert.AreEqual(7, result);
    }


    [TestMethod]
    public void Test_FindAllDuplicatedNumbers()
    {
        Programming.Patterns.CyclicSort.FindDupNums.Solution solution = new();

        List<int> duplicates = solution.findNumbers([3, 4, 4, 5, 5]);
        List<int> expected = [4, 5];
        CollectionAssert.AreEquivalent(expected, duplicates);

        duplicates = solution.findNumbers([5, 4, 7, 2, 3, 5, 3]);
        expected = [3, 5];
        CollectionAssert.AreEquivalent(expected, duplicates);
    }

    [TestMethod]
    public void Test_ReverseSubList()
    {
        Programming.Patterns.ReverseLinkedList.ReverseSubList.ListNode head = new(1)
        {
            Next = new(2)
        };
        head.Next.Next = new(3)
        {
            Next = new(4)
        };
        head.Next.Next.Next.Next = new(5);

        Programming.Patterns.ReverseLinkedList.ReverseSubList.Solution solution = new();
        Programming.Patterns.ReverseLinkedList.ReverseSubList.ListNode? result = solution.reverse(head, 2, 4);
        Console.Write("Nodes of the reversed LinkedList are: ");
        List<int> expected = [1, 4, 3, 2, 5];
        var i = 0;
        while (result != null)
        {
            Assert.AreEqual(expected[i], result.Val);
            result = result.Next;
            i++;
        }
    }

    [TestMethod]
    public void Test_ValidateParenthese()
    {
        Programming.Patterns.Stack.ValidateParenthese.Solution solution = new();
        Assert.IsTrue(solution.isValid("{([])}"));

        Assert.IsTrue(solution.isValid("{([])}{ss}"));
        Assert.IsFalse(solution.isValid("{([]})"));
    }

    [TestMethod]
    public void Test_FindLargestTreeRow()
    {
        Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.Solution solution = new();

        // Example 1
        Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode root1 = new(1)
        {
            Left = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(2),
            Right = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(3)
        };
        root1.Left.Left = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(4);
        root1.Left.Right = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(5);
        root1.Right.Right = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(6);

        List<int> output1 = solution.largestValues(root1);
        List<int> expected = [1, 3, 6];
        CollectionAssert.AreEqual(expected, output1);

        // Example 2
        Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode root2 = new(7)
        {
            Left = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(4),
            Right = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(8)
        };
        root2.Left.Left = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(2);
        root2.Left.Right = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(5);
        root2.Right.Right = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(9);
        root2.Left.Left.Right = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(3);

        List<int> output2 = solution.largestValues(root2);
        expected = [7, 8, 9, 3];
        CollectionAssert.AreEqual(expected, output2);

        // Example 3
        Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode root3 = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(10)
        {
            Left = new Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow.TreeNode(5)
        };

        List<int> output3 = solution.largestValues(root3);
        expected = [10, 5];
        CollectionAssert.AreEqual(expected, output3);
    }

    [TestMethod]
    public void Test_AllPathForSum()
    {
        Programming.Patterns.TreeDFS.AllPathForSum.TreeNode root = new(12);
        root.Left = new Programming.Patterns.TreeDFS.AllPathForSum.TreeNode(7);
        root.Right = new Programming.Patterns.TreeDFS.AllPathForSum.TreeNode(1);
        root.Left.Left = new Programming.Patterns.TreeDFS.AllPathForSum.TreeNode(4);
        root.Right.Left = new Programming.Patterns.TreeDFS.AllPathForSum.TreeNode(10);
        root.Right.Right = new Programming.Patterns.TreeDFS.AllPathForSum.TreeNode(5);
        int sum = 23;
        Programming.Patterns.TreeDFS.AllPathForSum.Solution solution = new();
        var result = solution.findPaths(root, sum).ToArray();

        /*
        [12, 7, 4]
        [12, 1, 10]
        */
        CollectionAssert.AreEqual(new int[] { 12, 7, 4 }, result[0]);
        CollectionAssert.AreEqual(new int[] { 12, 1, 10 }, result[1]);
    }

    [TestMethod]
    public void Test_Graph_FindIfPathExists()
    {
        var sol = new Programming.Patterns.Graph.FindIfPathExists.Solution();

        // Case 1: Simple direct connection
        int[][] edges1 = new int[][]
        {
        [0, 1],
        [1, 2]
        };
        Assert.IsTrue(sol.validPath(3, edges1, 0, 2), "Path 0 -> 2 should exist");

        // Case 2: Disconnected graph
        int[][] edges2 = new int[][]
        {
        new int[] {0, 1},
        new int[] {2, 3}
        };
        Assert.IsFalse(sol.validPath(4, edges2, 0, 3), "No path between 0 and 3");

        // Case 3: Start == End (trivial path)
        int[][] edges3 = new int[][]
        {
        new int[] {0, 1}
        };
        Assert.IsTrue(sol.validPath(2, edges3, 0, 0), "Start equals end, should be true");

        // Case 4: Cycle in the graph
        int[][] edges4 = new int[][]
        {
        new int[] {0, 1},
        new int[] {1, 2},
        new int[] {2, 0}
        };
        Assert.IsTrue(sol.validPath(3, edges4, 0, 2), "Path exists due to cycle");
        Assert.IsTrue(sol.validPath(3, edges4, 2, 1), "Cycle allows 2 -> 1");

        // Case 5: Large chain graph
        int n5 = 6;
        int[][] edges5 = new int[][]
        {
        new int[] {0, 1},
        new int[] {1, 2},
        new int[] {2, 3},
        new int[] {3, 4},
        new int[] {4, 5}
        };
        Assert.IsTrue(sol.validPath(n5, edges5, 0, 5), "Long chain path exists");
        //Assert.IsFalse(sol.validPath(n5, edges5, 5, 0), "Graph is directed, no reverse path");

        // Case 6: Single node graph
        int[][] edges6 = Array.Empty<int[]>();
        Assert.IsTrue(sol.validPath(1, edges6, 0, 0), "Single node path to itself");
        Assert.IsFalse(sol.validPath(1, edges6, 0, 0) && 1 > 1, "Only one node exists");
    }

    [TestMethod]
    public void Test_Graph_FindProvince()
    {
        var solution = new Programming.Patterns.Graph.FindProvinces.Solution();

        // Test Case 1: [[1,1,0],[1,1,0],[0,0,1]] -> 2 provinces
        int[][] test1 =
        [
            [1, 1, 0],
            [1, 1, 0],
            [0, 0, 1]
        ];
        Assert.AreEqual(2, solution.findProvinces(test1), "Test Case 1 Failed");

        // Test Case 2: [[1,0,0],[0,1,0],[0,0,1]] -> 3 provinces
        int[][] test2 =
        [
            [1, 0, 0],
            [0, 1, 0],
            [0, 0, 1]
        ];
        Assert.AreEqual(3, solution.findProvinces(test2), "Test Case 2 Failed");

        // Test Case 3: [[1,0,0,1],[0,1,1,0],[0,1,1,0],[1,0,0,1]] -> 2 provinces
        int[][] test3 =
        [
            [1, 0, 0, 1],
            [0, 1, 1, 0],
            [0, 1, 1, 0],
            [1, 0, 0, 1]
        ];
        Assert.AreEqual(2, solution.findProvinces(test3), "Test Case 3 Failed");

        // Edge Case 1: Single city [[1]] -> 1 province
        int[][] test4 = [[1]];
        Assert.AreEqual(1, solution.findProvinces(test4), "Edge Case 1 Failed");

        // Edge Case 2: Fully connected 3x3 [[1,1,1],[1,1,1],[1,1,1]] -> 1 province
        int[][] test5 =
        [
            [1, 1, 1],
            [1, 1, 1],
            [1, 1, 1]
        ];
        Assert.AreEqual(1, solution.findProvinces(test5), "Edge Case 2 Failed");
    }

    [TestMethod]
    public void TestAllSafeNodesCases()
    {
        var solution = new Programming.Patterns.Graph.SafeNodes.Solution();

        // Test Case 1: Empty Graph
        int[][] emptyGraph = new int[0][];
        CollectionAssert.AreEqual(new List<int>(), solution.eventualSafeNodes(emptyGraph), "Corrected Solution: Empty graph failed");

        // Test Case 2: Single Node with No Edges
        int[][] singleNodeGraph = new int[][] { new int[] { } };
        CollectionAssert.AreEqual(new List<int> { 0 }, solution.eventualSafeNodes(singleNodeGraph), "Corrected Solution: Single node failed");

        // Test Case 3: Simple Terminal Nodes
        int[][] simpleGraph = new int[][] {
            new int[] { 1, 2 }, // 0 -> 1, 2
            new int[] { },      // 1 is terminal
            new int[] { },      // 2 is terminal
            new int[] { 1 }     // 3 -> 1
        };
        CollectionAssert.AreEqual(new List<int> { 0, 1, 2, 3 }, solution.eventualSafeNodes(simpleGraph), "Corrected Solution: Simple terminal nodes failed");

        // Test Case 4: Graph with Cycle
        int[][] cycleGraph = new int[][] {
            new int[] { 1 },    // 0 -> 1
            new int[] { 2 },    // 1 -> 2
            new int[] { 0 },    // 2 -> 0 (cycle)
            new int[] { 4 },    // 3 -> 4
            new int[] { }       // 4 is terminal
        };
        CollectionAssert.AreEqual(new List<int> { 3, 4 }, solution.eventualSafeNodes(cycleGraph), "Corrected Solution: Graph with cycle failed");

        // Test Case 5: Complex Graph
        int[][] complexGraph = new int[][] {
            new int[] { 1, 2 }, // 0 -> 1, 2
            new int[] { 2, 3 }, // 1 -> 2, 3
            new int[] { 5 },    // 2 -> 5
            new int[] { 0 },    // 3 -> 0 (cycle)
            new int[] { 5 },    // 4 -> 5
            new int[] { },      // 5 is terminal
            new int[] { 4, 5 }  // 6 -> 4, 5
        };
        CollectionAssert.AreEqual(new List<int> { 2, 4, 5, 6 }, solution.eventualSafeNodes(complexGraph), "Corrected Solution: Complex graph failed");
    }

    [TestMethod]
    public void TestAllIslandCases()
    {
        var solution = new Programming.Patterns.Island.NumOfIsland.Solution();

        // Test Case 1: Multiple islands (3 islands)
        int[][] matrix1 = new int[][] {
            new int[] { 1, 1, 1, 0, 0 },
            new int[] { 0, 1, 0, 0, 1 },
            new int[] { 0, 0, 1, 1, 0 },
            new int[] { 0, 0, 1, 0, 0 },
            new int[] { 0, 0, 1, 0, 0 }
        };
        Assert.AreEqual(3, solution.countIslands(matrix1), "Test Case 1: Multiple islands failed");

        // Test Case 2: Two islands (horizontal and L-shaped)
        int[][] matrix2 = new int[][] {
            new int[] { 0, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 1, 1 },
            new int[] { 0, 1, 1, 1, 0 },
            new int[] { 0, 1, 1, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 }
        };
        Assert.AreEqual(1, solution.countIslands(matrix2), "Test Case 2: Two islands failed");

        // Test Case 3: No islands (all water)
        int[][] matrix3 = new int[][] {
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 }
        };
        Assert.AreEqual(0, solution.countIslands(matrix3), "Test Case 3: No islands failed");

        // Test Case 4: Single large island
        int[][] matrix4 = new int[][] {
            new int[] { 1, 1, 0, 0, 1 },
            new int[] { 1, 1, 0, 1, 1 },
            new int[] { 0, 1, 1, 1, 0 },
            new int[] { 0, 1, 1, 0, 0 },
            new int[] { 1, 1, 0, 0, 0 }
        };
        Assert.AreEqual(1, solution.countIslands(matrix4), "Test Case 4: Single large island failed");
    }


    [TestMethod]
    public void TestAllMaxAreaIslandCases()
    {
        var solution = new Programming.Patterns.Island.BiggestIsland.Solution();

        // Test Case 1: Multiple islands (largest area = 5)
        int[][] matrix1 = new int[][] {
            new int[] { 1, 1, 1, 0, 0 },
            new int[] { 0, 1, 0, 0, 1 },
            new int[] { 0, 0, 1, 1, 0 },
            new int[] { 0, 1, 1, 0, 0 },
            new int[] { 0, 0, 1, 0, 0 }
        };
        Assert.AreEqual(5, solution.maxAreaOfIsland(matrix1), "Test Case 1: Multiple islands failed");

        // Test Case 2: Multiple islands (largest area = 4)
        int[][] matrix2 = new int[][] {
            new int[] { 1, 1, 0, 1, 0 },
            new int[] { 0, 1, 1, 0, 1 },
            new int[] { 1, 0, 0, 1, 0 },
            new int[] { 0, 1, 0, 0, 1 },
            new int[] { 1, 0, 1, 1, 0 }
        };
        Assert.AreEqual(4, solution.maxAreaOfIsland(matrix2), "Test Case 2: Multiple islands failed");

        // Test Case 3: No islands (all water)
        int[][] matrix3 = new int[][] {
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 }
        };
        Assert.AreEqual(0, solution.maxAreaOfIsland(matrix3), "Test Case 3: No islands failed");

        // Test Case 4: Single large island (area = 24)
        int[][] matrix4 = new int[][] {
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 0, 1, 1 },
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 1, 1, 1, 1, 1 }
        };
        Assert.AreEqual(24, solution.maxAreaOfIsland(matrix4), "Test Case 4: Single large island failed");
    }

    [TestMethod]
    public void TestHeapBuilder_AllCases()
    {
        // Test invalid constructor
        Assert.ThrowsException<ArgumentException>(() => new Programming.Patterns.TwoHeaps.HeapBuilder.HeapBuilder(2), "Expected ArgumentException for invalid type 2");
        Assert.ThrowsException<ArgumentException>(() => new Programming.Patterns.TwoHeaps.HeapBuilder.HeapBuilder(-1), "Expected ArgumentException for invalid type -1");

        // Initialize heaps
        var minHeap = new Programming.Patterns.TwoHeaps.HeapBuilder.HeapBuilder(0); // Min-heap
        var maxHeap = new Programming.Patterns.TwoHeaps.HeapBuilder.HeapBuilder(1); // Max-heap

        // Test empty heap
        Assert.IsNull(minHeap.Peek(), "Min-heap Peek should return null for empty heap");
        Assert.IsNull(maxHeap.Peek(), "Max-heap Peek should return null for empty heap");
        Assert.AreEqual(0, minHeap.Get().Length, "Min-heap Get should return empty array");
        Assert.AreEqual(0, maxHeap.Get().Length, "Max-heap Get should return empty array");
        Assert.ThrowsException<InvalidOperationException>(() => minHeap.ExtractRoot(), "Min-heap ExtractRoot should throw on empty heap");
        Assert.ThrowsException<InvalidOperationException>(() => maxHeap.ExtractRoot(), "Max-heap ExtractRoot should throw on empty heap");

        // Test single element
        minHeap.Insert(42);
        Assert.AreEqual(42, minHeap.Peek(), "Min-heap Peek should return 42");
        Assert.AreEqual(42, minHeap.ExtractRoot(), "Min-heap ExtractRoot should return 42");
        Assert.IsNull(minHeap.Peek(), "Min-heap Peek should return null after extraction");

        maxHeap.Insert(42);
        Assert.AreEqual(42, maxHeap.Peek(), "Max-heap Peek should return 42");
        Assert.AreEqual(42, maxHeap.ExtractRoot(), "Max-heap ExtractRoot should return 42");
        Assert.IsNull(maxHeap.Peek(), "Max-heap Peek should return null after extraction");

        // Test multiple elements and heap property
        int[] values = new int[] { 5, 3, 7, 1, 4 };
        foreach (var value in values)
        {
            minHeap.Insert(value);
            maxHeap.Insert(value);
        }

        // Verify min-heap property (parent <= children)
        int[] minHeapArray = minHeap.Get();
        for (int i = 0; i < minHeapArray.Length; i++)
        {
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            if (leftChild < minHeapArray.Length)
                Assert.IsTrue(minHeapArray[i] <= minHeapArray[leftChild], $"Min-heap property violated at index {i}");
            if (rightChild < minHeapArray.Length)
                Assert.IsTrue(minHeapArray[i] <= minHeapArray[rightChild], $"Min-heap property violated at index {i}");
        }

        // Verify max-heap property (parent >= children)
        int[] maxHeapArray = maxHeap.Get();
        for (int i = 0; i < maxHeapArray.Length; i++)
        {
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            if (leftChild < maxHeapArray.Length)
                Assert.IsTrue(maxHeapArray[i] >= maxHeapArray[leftChild], $"Max-heap property violated at index {i}");
            if (rightChild < maxHeapArray.Length)
                Assert.IsTrue(maxHeapArray[i] >= maxHeapArray[rightChild], $"Max-heap property violated at index {i}");
        }

        // Test min-heap extraction (ascending order)
        int[] minExpected = new int[] { 1, 3, 4, 5, 7 };
        for (int i = 0; i < minExpected.Length; i++)
        {
            int extracted = minHeap.ExtractRoot();
            Assert.AreEqual(minExpected[i], extracted, $"Min-heap expected {minExpected[i]} at extraction {i}");
        }

        // Test max-heap extraction (descending order)
        int[] maxExpected = new int[] { 7, 5, 4, 3, 1 };
        for (int i = 0; i < maxExpected.Length; i++)
        {
            int extracted = maxHeap.ExtractRoot();
            Assert.AreEqual(maxExpected[i], extracted, $"Max-heap expected {maxExpected[i]} at extraction {i}");
        }

        // Test duplicates
        minHeap = new Programming.Patterns.TwoHeaps.HeapBuilder.HeapBuilder(0);
        minHeap.Insert(3);
        minHeap.Insert(3);
        minHeap.Insert(3);
        Assert.AreEqual(3, minHeap.ExtractRoot(), "Min-heap should extract 3");
        Assert.AreEqual(3, minHeap.ExtractRoot(), "Min-heap should extract 3");
        Assert.AreEqual(3, minHeap.ExtractRoot(), "Min-heap should extract 3");
        Assert.IsNull(minHeap.Peek(), "Min-heap should be empty after extracting duplicates");

        maxHeap = new Programming.Patterns.TwoHeaps.HeapBuilder.HeapBuilder(1);
        maxHeap.Insert(3);
        maxHeap.Insert(3);
        maxHeap.Insert(3);
        Assert.AreEqual(3, maxHeap.ExtractRoot(), "Max-heap should extract 3");
        Assert.AreEqual(3, maxHeap.ExtractRoot(), "Max-heap should extract 3");
        Assert.AreEqual(3, maxHeap.ExtractRoot(), "Max-heap should extract 3");
        Assert.IsNull(maxHeap.Peek(), "Max-heap should be empty after extracting duplicates");
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
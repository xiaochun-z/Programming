namespace Programming.Patterns.TreeDFS.DepthFirstSearch;
/*
Problem Statement

Given the root of a binary tree, explore all possible root-to-leaf paths, compute the sum of values along each path, and return the minimum sum.

A leaf node is a node with no children.
       10
      / \
     5   15
         / \
        7  20
Example 1:

    Input: root = [10, 5, 15, null, null, 7, 20]


    Expected Output: 15
    Justification: The path with the minimum sum is 10 -> 5. The sum is 10 + 5 = 15.

*/
using System;

public class TreeNode {
    public int Val;
    public TreeNode? Left;
    public TreeNode? Right;

    // Constructor
    public TreeNode(int val) {
        Val = val;
        Left = null;
        Right = null;
    }
}

public class Solution {
    // Main function to return the minimum root to leaf sum
    public int minRootToLeafSum(TreeNode root) {
        // Base case: if the tree is empty, return a large value since we are finding the minimum sum
        if (root == null) {
            return int.MaxValue;
        }

        // Base case: if we reached a leaf node, return its value
        if (root.Left == null && root.Right == null) {
            return root.Val;
        }

        // Recursive case: compute the minimum sum for left and right subtrees
        int leftSum = minRootToLeafSum(root.Left!);
        int rightSum = minRootToLeafSum(root.Right!);

        // Return the minimum of the two sums, adding the current node's value
        return root.Val + Math.Min(leftSum, rightSum);
    }
    
    public static void Main(string[] args) {
        // Example 1: Create the tree manually
        TreeNode root1 = new TreeNode(10);
        root1.Left = new TreeNode(5);
        root1.Right = new TreeNode(15);
        root1.Right.Left = new TreeNode(7);
        root1.Right.Right = new TreeNode(20);
        
        // Example 2: Create another tree
        TreeNode root2 = new TreeNode(-1);
        root2.Left = new TreeNode(2);
        root2.Right = new TreeNode(3);
        root2.Left.Left = new TreeNode(4);
        root2.Left.Right = new TreeNode(5);
        root2.Right.Left = new TreeNode(1);
        
        // Example 3: Create a third tree
        TreeNode root3 = new TreeNode(8);
        root3.Left = new TreeNode(40);
        root3.Right = new TreeNode(12);
        root3.Right.Left = new TreeNode(10);
        root3.Right.Right = new TreeNode(18);
        root3.Right.Left.Left = new TreeNode(2);
        
        Solution solution = new Solution();
        
        // Print results for each example
        Console.WriteLine("Minimum Root to Leaf Path Sum (Example 1): " + solution.minRootToLeafSum(root1)); // Output: 15
        Console.WriteLine("Minimum Root to Leaf Path Sum (Example 2): " + solution.minRootToLeafSum(root2)); // Output: 3
        Console.WriteLine("Minimum Root to Leaf Path Sum (Example 3): " + solution.minRootToLeafSum(root3)); // Output: 32
    }
}

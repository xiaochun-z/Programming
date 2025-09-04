namespace Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow;

using System;
using System.Collections.Generic;

// Definition for a binary tree node
public class TreeNode
{
    public int Val;
    public TreeNode? Left;
    public TreeNode? Right;

    public TreeNode(int val)
    {
        this.Val = val;
        this.Left = null;
        this.Right = null;
    }
}

public class Solution
{

    // Method to find the largest value in each row of the binary tree
    public List<int> largestValues(TreeNode root)
    {
        List<int> result = new List<int>();
        // ToDo: Write Your Code Here.
        return result;
    }
}
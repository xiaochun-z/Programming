namespace Programming.Patterns.TreeDFS.AllPathForSum;

/*
All Paths for a Sum (medium)

Problem Statement

Given a binary tree and a number ‘S’, find all paths from root-to-leaf such that the sum of all the node values of each path equals ‘S’.
Example:
S:12
      1
   /     \
  7       9
 / \     / \
4   5   2   7

output:
[[1,7,4], [1,9,2]]

Constraints:

    The number of nodes in the tree is in the range [0, 5000].
    -1000 <= Node.val <= 1000
    -1000 <= targetSum <= 1000

*/

using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

public class TreeNode
{
    public int Val;
    public TreeNode? Left;
    public TreeNode? Right;

    public TreeNode(int x)
    {
        Val = x;
    }
}

public class Solution
{
    public List<List<int>> findPaths(TreeNode root, int sum)
    {
        List<List<int>> allPaths = [];

        List<int> curPath = [];
        DepthFirstSearch(root, allPaths, curPath, sum);

        return allPaths;
    }

    private void DepthFirstSearch(TreeNode node, List<List<int>> allPaths, List<int> curPath, int sum)
    {
        if (node == null) return;
        curPath.Add(node.Val);
        if (node.Left == null && node.Right == null)
        {
            if (node.Val == sum)
            {
                allPaths.Add([.. curPath]);
            }
        }

        if (node.Left != null)
        {
            DepthFirstSearch(node.Left, allPaths, curPath, sum - node.Val);
        }

        if (node.Right != null)
        {
            DepthFirstSearch(node.Right, allPaths, curPath, sum - node.Val);
        }

        curPath.RemoveAt(curPath.Count - 1);
    }
}

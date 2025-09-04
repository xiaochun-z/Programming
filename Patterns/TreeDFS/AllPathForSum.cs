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

        if (root == null) return allPaths;

        // stack 里放三元组：当前节点, 当前路径, 剩余和
        Stack<(TreeNode node, List<int> path, int remain)> stack = new();
        stack.Push((root, new List<int>() { root.Val }, sum - root.Val));

        while (stack.Count > 0)
        {
            var (node, path, remain) = stack.Pop();

            // 如果是叶子并且剩余和为 0，则记录路径
            if (node.Left == null && node.Right == null && remain == 0)
            {
                allPaths.Add([.. path]);
            }

            // 注意：stack 是后进先出，要先压右子树，再压左子树
            if (node.Right != null)
            {
                var newPath = new List<int>(path) { node.Right.Val };
                stack.Push((node.Right, newPath, remain - node.Right.Val));
            }

            if (node.Left != null)
            {
                var newPath = new List<int>(path) { node.Left.Val };
                stack.Push((node.Left, newPath, remain - node.Left.Val));
            }
        }

        return allPaths;
    }

    public List<List<int>> findPaths2(TreeNode root, int sum)
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

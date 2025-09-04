namespace Programming.Patterns.LevelOrderTraversal.ReverseLevelOrderTraversal;
/*
Problem Statement

Given the root of a binary tree, return the bottom-up level order traversal of its nodes' values. (i.e., the lowest level comes first in left to right order.)
Examples
Example 1

    Input: root = [1, 2, 3, 4, 5, 6, 7]

    Expected Output: [[4, 5, 6, 7], [2, 3], [1]]
    Justification:
        The third level has 4, 5, 6, and 7 nodes.
        The second level has 2 and 3 nodes.
        The first level has a single node with the value 1.

Example 2

    Input: root = [12, 7, 1, null, 9, 10, 5]

    Expected Output: [[9, 10, 5], [7, 1], [12]]
    Justification:
        The third level has 9, 10, and 5 nodes.
        The second level has 7 and 1 nodes.
        The first level has a single node with the value 12.

Example 3

    Input: root = [6,5,2,null,null,1,6,3,56,3]

    Expected Output: [[3,56,3],[1,6],[5,2],[6]]
    Justification:
        The fourth level has 3, 56, and 3 nodes.
        The third level has 1, and 6 nodes.
        The second level has 5 and 2 nodes.
        The first level has a single node with the value 6.

Constraints:

    The number of nodes in the tree is in the range [0, 2000].
    -1000 <= Node.val <= 1000

*/
using System;
using System.Collections.Generic;

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
    public List<List<int>> traverse(TreeNode root)
    {
        if (root == null) return [[]];
        List<List<int>> result = [];

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var level_size = queue.Count; // remember the size is important, because we're going to enqueue more down below.
            List<int> level_result = [];
            for (var i = 0; i < level_size; i++)
            {
                var node = queue.Dequeue();
                level_result.Add(node.Val);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            result.Insert(0, level_result);
        }

        return result;
    }
}
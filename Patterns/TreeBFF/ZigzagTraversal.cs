namespace Programming.Patterns.TreeBFF.ZigzagTraversal;

/*
Problem Statement

Given a binary tree, populate an array to represent its zigzag level order traversal. You should populate the values of all nodes of the first level from left to right, then right to left for the next level and keep alternating in the same manner for the following levels.

Example 1:
      1
   /     \
  3       4
 / \     / \
5   6   7   8

output

[[1],
[4,3]
[5,6,7,8]
]
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
        if (root == null) return [];

        List<List<int>> result = [];
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int level = 0;
        while (queue.Count > 0)
        {
            var level_size = queue.Count;
            var level_list = new List<int>(level_size);
            for (var i = 0; i < level_size; i++)
            {
                var node = queue.Dequeue();
                if (level % 2 == 1)
                    level_list.Insert(0, node.Val);
                else
                    level_list.Add(node.Val);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            result.Add(level_list);
            level++;
        }
        return result;
    }
}



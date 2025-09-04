namespace Programming.Patterns.TreeBFS.BinaryTreeTraversal;

/*
Binary Tree Level Order Traversal
Problem Statement

Given a binary tree, populate an array to represent its level-by-level traversal. You should populate the values of all nodes of each level from left to right in separate sub-arrays.


 Example:
       1
     /    \
    2      3
   /\    /   \
 4   5   6   7

 output:
 [[1],
 [2,3],
 [4,5,6,7]]
*/

using System;
using System.Collections.Generic;

public class TreeNode {
    public int Val;
    public TreeNode? Left;
    public TreeNode? Right;

    public TreeNode(int x) {
        Val = x;
    }
}

public class Solution {
    public List<List<int>> traverse(TreeNode root) {
        if (root == null) return [];
        List<List<int>> result = [];
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var level_size = queue.Count;
            List<int> level_list = new(level_size);
            for (var i = 0; i < level_size; i++)
            {
                var node = queue.Dequeue();
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
        }

        return result;
    }
}

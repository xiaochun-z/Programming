namespace Programming.Patterns.LevelOrderTraversal.FindLargestTreeRow;
/*
Find Largest Value in Each Tree Row (medium)

Example 1

     1
  /      \ 
  2       3
 / \    /   \ 
4  5  null   6

    Input: root = [1, 2, 3, 4, 5, null, 6]
    Expected Output: [1, 3, 6]

    Justification:
        The first row contains 1. The largest value is 1.
        The second row has 2 and 3, and the largest is 3.
        The third row has 4, 5, and 6, and the largest is 6.

Example 2

            7
        /        \ 
       4          8
     /   \      /    \
    2      5   null   9
  /   \
null   3

    Input: root = [7, 4, 8, 2, 5, null, 9, null, 3]
    Expected Output: [7, 8, 9, 3]

    Justification:
        The first row contains 7, and the largest value is 7.
        The second row has 4 and 8, and the largest is 8.
        The third row has 2, 5, and 9, and the largest is 9.
        The fourth row has 3, and the largest is 3.

Example 3

  10
 /
5

    Input: root = [10, 5]
    Expected Output: [10, 5]
    Justification:
        The first row has 10, and the largest value is 10.
        The second row contains 5, and the largest is 5.

Constraints:

    The number of nodes in the tree will be in the range [0, 104].
    -231 <= Node.val <= 231 - 1

*/
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
        if (root == null) return [];

        List<int> result = [];
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var level_size = queue.Count;
            int[] arr = new int[level_size];
            for (var i = 0; i < level_size; i++)
            {
                var node = queue.Dequeue();
                arr[i] = node.Val;

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            result.Add(arr.Max());
        }

        return result;
    }
}
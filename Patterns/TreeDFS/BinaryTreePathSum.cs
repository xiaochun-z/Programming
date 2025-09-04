namespace Programming.Patterns.TreeDFS.BinaryTreePathSum;

/*
Problem Statement

Given a root of the binary tree and an integer ‘S’, return true if the tree has a path from root-to-leaf such that the sum of all the node values of that path equals ‘S’. Otherwise, return false.
Examples
Example 1:

       1
   /       \
  2        3
/  \      / \
4   5    6   7

    Input: root = [1, 2, 3, 4, 5, 6, 7], S = 10

    Expected Output: true
    Justification: The tree has 1 -> 3 -> 6 root-to-leaf path having sum equal to 10.


Example 2:

     12
  /      \
 7        1 
/       /   \
9      10   5

    Input: root = [12, 7, 1, 9, null, 10, 5], S = 23
    Expected Output: true
    Justification: The tree has 12 -> 1 -> 10 root-to-leaf path having sum equal to 23.


Example 3:

      12
   /       \
  7         1
 /         /  \
9         10   5

    Input: root = [12, 7, 1, 9, null, 10, 5], S = 16
    Expected Output: false
    Justification: The tree doesn't have root-to-leaf path having sum equal to 16.

Constraints:

    The number of nodes in the tree is in the range [0, 5000].
    -1000 <= Node.val <= 1000
    -1000 <= targetSum <= 1000

*/

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
    public bool hasPath(TreeNode root, int sum)
    {
        if (root == null) return false;
        if (root.Left == null && root.Right == null) // leaf node
            if (root.Val == sum)
                return true;

        if (root.Left != null)
        {
            if (hasPath(root.Left, sum - root.Val))
                return true;
        }

        if (root.Right != null)
        {
            if (hasPath(root.Right, sum - root.Val))
                return true;
        }

        return false;
    }
}

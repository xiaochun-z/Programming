namespace Programming.Patterns.MonotonicStack.RemoveNodes;
/*
Problem Statement

Given the head node of a singly linked list, modify the list such that any node that has a node with a greater value to its right gets removed. The function should return the head of the modified list.

Examples:

    Input: 5 -> 3 -> 7 -> 4 -> 2 -> 1
    Output: 7 -> 4 -> 2 -> 1
    Explanation: 5 and 3 are removed as they have nodes with larger values to their right.

    Input: 1 -> 2 -> 3 -> 4 -> 5
    Output: 5
    Explanation: 1, 2, 3, and 4 are removed as they have nodes with larger values to their right.

    Input: 5 -> 4 -> 3 -> 2 -> 1
    Output: 5 -> 4 -> 3 -> 2 -> 1
    Explanation: None of the nodes are removed as none of them have nodes with larger values to their right.

Constraints:

    The number of the nodes in the given list is in the range [1, 105].
    1 <= Node.val <= 105

*/
using System;
using System.Collections.Generic;

public class ListNode
{
    public int Val;
    public ListNode? Next;

    public ListNode(int Val)
    {
        this.Val = Val;
    }
}

public class Solution
{
    public ListNode removeNodes(ListNode head)
    {
        Stack<ListNode> stack = new();  // Create a stack to store nodes in descending order

        ListNode cur = head;
        while (cur != null)
        {
            while (stack.Count > 0 && stack.Peek().Val < cur.Val)
            {
                stack.Pop();  // Remove nodes from the stack that are smaller than the current node
            }

            if (stack.Count > 0)
            {
                stack.Peek().Next = cur;  // Update the 'Next' of the top node in the stack
            }
            else
            {
                // Reset the head if we've popped all nodes so far.
                head = cur;
            }

            stack.Push(cur);  // Push the current node onto the stack
            cur = cur.Next;
        }

        // Ensure the last node in the stack's 'Next' points to null
        if (stack.Count > 0)
        {
            stack.Peek().Next = null;
        }

        return head;  // Return the head of the modified list
    }
}

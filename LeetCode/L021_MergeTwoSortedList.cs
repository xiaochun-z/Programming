namespace LeetCode.L021_MergeTwoSortedList;


public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public int[] ToArray()
    {
        var result = new List<int>();
        var current = this;
        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }
        return [.. result];
    }
}

public class Solution
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        if (list1.val <= list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}
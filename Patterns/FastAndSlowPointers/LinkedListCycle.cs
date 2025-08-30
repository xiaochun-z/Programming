namespace Programming.Patterns.FastAndSlowPointers.LinkedListCycle;

public class ListNode
{
  public int Value = 0;
  public ListNode? Next;

  public ListNode(int value)
  {
    this.Value = value;
  }
}

public class Solution
{

  public bool hasCycle(ListNode head)
  {
    ListNode? fast = head;
    ListNode? slow = head;
    while (fast != null && fast.Next != null)
    {
      fast = fast.Next.Next;
      slow = slow?.Next;

      if (fast == slow)
      {
        return true;
      }
    }
    return false;
  }
}

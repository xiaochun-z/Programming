namespace UnitTests.DataStructure.CommonDataStructure;

[TestClass]
public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_Array()
    {
        int[] arr = new int[5];
        arr = [1, 2, 3, 4, 5];

        Console.WriteLine(arr[0]);

        Array.Clear(arr, 0, 3);
        var expected = new int[] { 0, 0, 0, 4, 5 };
        CollectionAssert.AreEqual(expected, arr);

        Assert.AreEqual(5, arr.Length);
        Assert.AreEqual(1, arr.Rank);

        int[] arr2 = new int[6];
        Array.Copy(arr, 3, arr2, 0, 2);
        CollectionAssert.AreEqual(new int[] { 4, 5, 0, 0, 0, 0 }, arr2);

        Array.Reverse(arr2);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 5, 4 }, arr2);

        Array.Sort(arr2);
        CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 4, 5 }, arr2);

        Assert.AreEqual(0, Array.IndexOf(arr2, 0));
        Assert.AreEqual(3, Array.LastIndexOf(arr2, 0));
        Assert.AreEqual(4, Array.LastIndexOf(arr2, 4));
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_LinkedList()
    {
        var list = new LinkedList<int>();
        list.AddFirst(1);
        list.AddLast(2);

        Assert.IsNotNull(list.First);
        Assert.AreEqual(1, list.First.Value);
        list.RemoveLast();
        Assert.AreEqual(1, list.First.Value);
        list.AddAfter(list.First, 3);
        CollectionAssert.AreEqual(new int[] { 1, 3 }, list.ToArray());

        list.AddLast(4);
        list.AddLast(5);
        list.AddBefore(list.First.Next, 2);
        CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, list.ToArray());
        list.Remove(list.Last);
        CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, list.ToArray());
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_Queue()
    {
        var queue = new Queue<int>();

        // Enqueue elements
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // Check count
        Assert.AreEqual(3, queue.Count);

        // Peek at the front element
        Assert.AreEqual(1, queue.Peek());

        // Dequeue elements
        Assert.AreEqual(1, queue.Dequeue());
        Assert.AreEqual(2, queue.Dequeue());

        // Check remaining count
        Assert.AreEqual(1, queue.Count);

        // Enqueue another element
        queue.Enqueue(4);

        // Convert to array and check order
        CollectionAssert.AreEqual(new int[] { 3, 4 }, queue.ToArray());

        // Clear the queue
        queue.Clear();
        Assert.AreEqual(0, queue.Count);
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_Stack()
    {
        var stack = new Stack<int>();

        // Push elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Check count
        Assert.AreEqual(3, stack.Count);

        // Peek at the top element
        Assert.AreEqual(3, stack.Peek());

        // Pop elements from the stack
        Assert.AreEqual(3, stack.Pop());
        Assert.AreEqual(2, stack.Pop());

        // Check remaining count
        Assert.AreEqual(1, stack.Count);

        // Push another element
        stack.Push(4);

        // Convert to array and check order (top to bottom)
        CollectionAssert.AreEqual(new int[] { 4, 1 }, stack.ToArray());

        // Clear the stack
        stack.Clear();
        Assert.AreEqual(0, stack.Count);
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_Dictionary()
    {
        var dict = new Dictionary<string, int>();

        // Add key-value pairs
        dict.Add("one", 1);
        dict["two"] = 2;
        dict["three"] = 3;

        // Check count
        Assert.AreEqual(3, dict.Count);

        // Access value by key
        Assert.AreEqual(2, dict["two"]);

        // Check if key exists
        Assert.IsTrue(dict.ContainsKey("three"));
        Assert.IsFalse(dict.ContainsKey("four"));

        // Remove a key
        dict.Remove("one");
        Assert.AreEqual(2, dict.Count);

        // TryGetValue usage
        int value;
        Assert.IsTrue(dict.TryGetValue("three", out value));
        Assert.AreEqual(3, value);

        // Enumerate keys and values
        CollectionAssert.AreEquivalent(new[] { "two", "three" }, dict.Keys.ToArray());
        CollectionAssert.AreEquivalent(new[] { 2, 3 }, dict.Values.ToArray());

        // Clear dictionary
        dict.Clear();
        Assert.AreEqual(0, dict.Count);
    }
}
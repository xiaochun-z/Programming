using System.Collections;
using System;
using System.Collections.Generic;

namespace UnitTests;

[TestClass]
public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_Array()
    {
        // Use Array when you need a fixed-size, fast, indexed collection of elements of the same type.
        // Best for performance-critical scenarios and when size is known in advance.
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
        // Use LinkedList when you need fast insertions and deletions anywhere in the list,
        // especially at the beginning or end, and don't need indexed access.
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
        Assert.IsNotNull(list.First.Next);
        list.AddBefore(list.First.Next, 2);
        CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, list.ToArray());
        Assert.IsNotNull(list.Last);
        list.Remove(list.Last);
        CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, list.ToArray());
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_Queue()
    {
        // Use Queue when you need FIFO (first-in, first-out) ordering,
        // such as processing tasks or buffering data.
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
        // Use Stack when you need LIFO (last-in, first-out) ordering,
        // such as undo functionality or evaluating expressions.
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
        // Use Dictionary when you need fast lookups, additions, and removals by key,
        // and keys are unique.
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

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_Tuple_ValueTuple()
    {
        // Use Tuple or ValueTuple for grouping multiple values together without creating a custom class,
        // especially for method returns or temporary data structures.
        // Using Tuple (reference type)
        var tuple = Tuple.Create("Alice", 30);
        Assert.AreEqual("Alice", tuple.Item1);
        Assert.AreEqual(30, tuple.Item2);

        // Using ValueTuple (struct, C# 7+)
        (string name, int age) valueTuple = ("Bob", 25);
        Assert.AreEqual("Bob", valueTuple.name);
        Assert.AreEqual(25, valueTuple.age);

        // Deconstruction
        var (n, a) = valueTuple;
        Assert.AreEqual("Bob", n);
        Assert.AreEqual(25, a);

        // ValueTuple with more elements
        var vt = (1, 2, 3, 4, 5, 6, 7);
        Assert.AreEqual(7, vt.Item7);

        // Tuple as method return
        (int sum, int product) Calc(int x, int y) => (x + y, x * y);
        var result = Calc(3, 4);
        Assert.AreEqual(7, result.sum);
        Assert.AreEqual(12, result.product);
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_BitArray()
    {
        // Use BitArray when you need to efficiently store and manipulate a collection of bits,
        // such as flags, binary data, or compact boolean arrays.
        // Create a BitArray of length 8
        var bits = new BitArray(8);

        // Set some bits
        bits.Set(0, true);
        bits.Set(3, true);
        bits[5] = true;

        // Check values
        Assert.IsTrue(bits[0]);
        Assert.IsFalse(bits[1]);
        Assert.IsTrue(bits[3]);
        Assert.IsTrue(bits[5]);

        // Count true bits
        int trueCount = bits.Cast<bool>().Count(b => b);
        Assert.AreEqual(3, trueCount);

        // Flip all bits
        bits.Not();
        Assert.IsFalse(bits[0]);
        Assert.IsTrue(bits[1]);
        Assert.IsFalse(bits[3]);
        Assert.IsFalse(bits[5]);

        // Set all bits to true
        bits.SetAll(true);
        Assert.IsTrue(bits.Cast<bool>().All(b => b));

        // Copy to bool array
        bool[] boolArr = new bool[8];
        bits.CopyTo(boolArr, 0);
        CollectionAssert.AreEqual(new bool[] { true, true, true, true, true, true, true, true }, boolArr);
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_ArrayList()
    {
        // Use ArrayList for storing a collection of objects of mixed types,
        // but prefer List<T> for type safety and performance in modern code.
        var arrayList = new ArrayList();

        // Add elements of different types
        arrayList.Add(1);
        arrayList.Add("two");
        arrayList.Add(3.0);

        // Check count
        Assert.AreEqual(3, arrayList.Count);

        // Access elements by index
        Assert.AreEqual(1, arrayList[0]);
        Assert.AreEqual("two", arrayList[1]);
        Assert.AreEqual(3.0, arrayList[2]);

        // Insert element
        arrayList.Insert(1, "inserted");
        Assert.AreEqual("inserted", arrayList[1]);

        // Remove element
        arrayList.Remove("two");
        Assert.IsFalse(arrayList.Contains("two"));

        // Remove by index
        arrayList.RemoveAt(0);
        Assert.AreEqual("inserted", arrayList[0]);

        // Clear all elements
        arrayList.Clear();
        Assert.AreEqual(0, arrayList.Count);
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_SortedList()
    {
        // Use SortedList when you need a collection of key/value pairs sorted by key,
        // and want to access elements by both key and index.
        var sortedList = new SortedList<int, string>();

        // Add key-value pairs
        sortedList.Add(3, "three");
        sortedList.Add(1, "one");
        sortedList.Add(2, "two");

        // Keys are automatically sorted
        CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, sortedList.Keys.ToArray());
        CollectionAssert.AreEqual(new string[] { "one", "two", "three" }, sortedList.Values.ToArray());

        // Access by key
        Assert.AreEqual("two", sortedList[2]);

        // Access by index
        Assert.AreEqual("one", sortedList.Values[0]);
        Assert.AreEqual(1, sortedList.Keys[0]);

        // Update value
        sortedList[2] = "TWO";
        Assert.AreEqual("TWO", sortedList[2]);

        // Remove by key
        sortedList.Remove(1);
        CollectionAssert.AreEqual(new int[] { 2, 3 }, sortedList.Keys.ToArray());

        // Check if key exists
        Assert.IsTrue(sortedList.ContainsKey(3));
        Assert.IsFalse(sortedList.ContainsKey(1));

        // Clear all elements
        sortedList.Clear();
        Assert.AreEqual(0, sortedList.Count);
    }
}

public partial class BasicDataStructure
{
    [TestMethod]
    public void Test_HashSet()
    {
        // Use HashSet when you need a collection of unique elements
        var hashSet = new HashSet<string>();

        // Add elements
        hashSet.Add("one");
        hashSet.Add("two");
        hashSet.Add("three");

        // Check count
        Assert.AreEqual(3, hashSet.Count);

        // Check if contains
        Assert.IsTrue(hashSet.Contains("two"));
        Assert.IsFalse(hashSet.Contains("four"));

        // Remove element
        hashSet.Remove("two");
        Assert.IsFalse(hashSet.Contains("two"));

        var result = hashSet.Add("three"); // Duplicate, won't be added
        Assert.IsFalse(result);

        // Clear all elements
        hashSet.Clear();
        Assert.AreEqual(0, hashSet.Count);
    }
}
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
        
    }
}
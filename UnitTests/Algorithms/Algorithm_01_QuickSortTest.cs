namespace UnitTests;

[TestClass]
public sealed class Algorithm_01_QuickSortTest
{
    [TestMethod]
    public void Test_SortsArrayCorrectly()
    {
        var solution = new Algorithm_01_QuickSort();
        var input = new int[] { 5, 6, 3, 8, 1 };
        var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.QuickSort(input);
        CollectionAssert.AreEqual(expected, result);
    }
}

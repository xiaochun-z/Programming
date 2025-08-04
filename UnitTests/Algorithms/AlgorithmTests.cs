namespace UnitTests;

[TestClass]
public sealed class AlgorithmTests
{
    [TestMethod]
    public void QuickSortTest()
    {
        var solution = new Algorithm_01_QuickSort();
        var input = new int[] { 5, 6, 3, 8, 1 };
        var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.QuickSort(input);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void MergeSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_02_MergeSort();
        var input = new int[] { 5, 6, 3, 8, 1 };
        var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.MergeSort(input);
        CollectionAssert.AreEqual(expected, result);
    }
}

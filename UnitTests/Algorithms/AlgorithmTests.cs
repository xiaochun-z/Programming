namespace UnitTests;

[TestClass]
public sealed class AlgorithmTests
{
    [TestMethod]
    public void QuickSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_01_QuickSort();
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

    [TestMethod]
    public void HeapSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_03_HeapSort();
        var input = new int[] { 5, 6, 3, 8, 1 };
        var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.HeapSort(input);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountingSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_04_CountingSort();
        var input = new int[] { 5, 6, 3, 8, 1 };
        var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.CountingSort(input);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void InsertSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_05_InsertSort();
        var input = new int[] { 5, 6, 3, 8, 1 };
        var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.InsertSort(input);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ShellSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_06_ShellSort();
        var input = new int[] { 5, 6, 3, 8, 1 };
        var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.ShellSort(input);
        CollectionAssert.AreEqual(expected, result);
    }
}

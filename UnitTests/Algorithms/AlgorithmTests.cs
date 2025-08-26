namespace UnitTests;

[TestClass]
public sealed class AlgorithmTests
{
    [TestMethod]
    public void QuickSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_01_QuickSort();
        var input = GenerateRandomArray(1000);
        // var expected = new int[] { 1, 3, 5, 6, 8 };
        var result = solution.QuickSort(input);
        // CollectionAssert.AreEqual(expected, result);
        Assert.IsTrue(IsSorted(result));
    }

    [TestMethod]
    public void QuickSortInPlaceTest()
    {
        var solution = new SortAlgoritms.Algorithm_01_QuickSort();
        var input = GenerateRandomArray(1000);
        solution.QuickSort(input, 0, input.Length - 1);
        Assert.IsTrue(IsSorted(input), "In-place QuickSort did not sort the array correctly.");
    }

    [TestMethod]
    public void MergeSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_02_MergeSort();
        var input = GenerateRandomArray(1000);
        var result = solution.MergeSort(input);
        Assert.IsTrue(IsSorted(result));
    }

    [TestMethod]
    public void HeapSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_03_HeapSort();
        var input = GenerateRandomArray(1000);
        var result = solution.HeapSort(input);
        Assert.IsTrue(IsSorted(result));
    }

    [TestMethod]
    public void CountingSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_04_CountingSort();
        var input = GenerateRandomArray(1000);
        var result = solution.CountingSort(input);
        Assert.IsTrue(IsSorted(result));
    }

    [TestMethod]
    public void InsertSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_05_InsertSort();
        var input = GenerateRandomArray(1000);
        var result = solution.InsertSort(input);
        Assert.IsTrue(IsSorted(result));
    }

    [TestMethod]
    public void ShellSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_06_ShellSort();
        var input = GenerateRandomArray(1000);
        var result = solution.ShellSort(input);
        Assert.IsTrue(IsSorted(result));
    }

    [TestMethod]
    public void BucketSortTest()
    {
        var solution = new SortAlgoritms.Algorithm_07_BucketSort();
        var input = GenerateRandomArray(1000);
        var result = solution.BucketSort(input);
        Assert.IsTrue(IsSorted(result), "BucketSort did not sort the array correctly.");
    }

    /// Gernerate 1000 random numbers and sort them with all algorithms
    private static int[] GenerateRandomArray(int size)
    {
        var random = new Random();
        return Enumerable.Range(0, size).Select(_ => random.Next(1, 10000)).ToArray();
    }

    /// Verify each number is sorted ascendingly
    private static bool IsSorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

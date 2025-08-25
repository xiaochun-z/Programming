namespace SortAlgoritms;

public class Algorithm_01_QuickSort
{
    /// <summary>
    /// not in-place quick sort but easy to understand
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[] QuickSort(int[] array)
    {
        if (array.Length == 0) return array;
        var pivot = array[array.Length / 2];
        var left = new List<int>();
        var right = new List<int>();
        var middle = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < pivot)
            {
                left.Add(array[i]);
            }
            else if (array[i] > pivot)
            {
                right.Add(array[i]);
            }
            else
            {
                middle.Add(array[i]);
            }
        }

        return QuickSort(left.ToArray()).Concat(middle).Concat(QuickSort(right.ToArray())).ToArray();
    }

    /// <summary>
    /// in-place quick sort with O(log n) space for recursion stack
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    public void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(arr, low, high);
            QuickSort(arr, low, p);     // sort left side
            QuickSort(arr, p + 1, high); // sort right side
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[(low + high) / 2]; // choose middle element as pivot
        int i = low - 1;
        int j = high + 1;

        while (true)
        {
            do { i++; } while (arr[i] < pivot);
            do { j--; } while (arr[j] > pivot);

            if (i >= j)
                return j;

            Swap(arr, i, j);
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}
namespace SortAlgoritms;

public class Algorithm_01_QuickSort
{
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
}
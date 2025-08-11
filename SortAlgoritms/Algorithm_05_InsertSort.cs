using System.Globalization;

namespace SortAlgoritms;

public class Algorithm_05_InsertSort
{
    public int[] InsertSort(int[] array)
    {
        if (array.Length == 0) return array;

        for (int i = 0; i < array.Length; i++)
        {
            int current = array[i];
            int j = i;
            for (; j > 0 && current < array[j - 1]; j--)
            {
                array[j] = array[j - 1];
            }
            array[j] = current;
        }

        return array;
    }
}
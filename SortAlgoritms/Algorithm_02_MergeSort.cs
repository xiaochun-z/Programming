namespace SortAlgoritms;

public class Algorithm_02_MergeSort
{
    public int[] MergeSort(int[] array)
    {
        if (array.Length <= 1) return array;

        var middle = array.Length / 2;
        var left = array.Take(middle).ToArray();
        var right = array.Skip(middle).ToArray();

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        List<int> result = [];
        int i = 0, j = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result.Add(left[i]);
                i++;
            }
            else
            {
                result.Add(right[j]);
                j++;
            }
        }

        while (i < left.Length) result.Add(left[i++]);
        while (j < right.Length) result.Add(right[j++]);

        return [.. result];
    }
}
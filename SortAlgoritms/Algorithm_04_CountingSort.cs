namespace SortAlgoritms;

public class Algorithm_04_CountingSort
{
    public int[] CountingSort(int[] array)
    {
        int max = array.Max();
        int min = array.Min();
        int range_of_elements = max - min + 1;

        int[] count = new int[range_of_elements];
        foreach (int num in array)
        {
            count[num - min]++;
        }

        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        int[] sorted = new int[array.Length];
        var reversed = array.Reverse().ToArray();
        foreach (int num in reversed)
        {
            count[num - min] -= 1;
            sorted[count[num - min]] = num;
        }
        // for (int i = 0; i < count.Length; i++)
        // {
        //     sorted.AddRange(Enumerable.Repeat(i + min, count[i]));
        // }

        return sorted;
    }
}
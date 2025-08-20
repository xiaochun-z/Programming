namespace SortAlgoritms;

public class Algorithm_06_ShellSort
{
    public int[] ShellSort(int[] array)
    {
        for (int gap = array.Length / 2; gap > 0; gap /= 2)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j >= gap && array[j] < array[j - gap])
                {
                    (array[j], array[j - gap]) = (array[j - gap], array[j]);
                    j -= gap;
                }
            }
        }

        return array;
    }
}
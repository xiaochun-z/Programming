namespace SortAlgoritms;

public class Algorithm_07_BucketSort
{
    public int[] BucketSort(int[] array)
    {
        if (array.Length == 0) return array;

        int max = array.Max();
        int min = array.Min();
        int bucketCount = (max - min) / 10 + 1; // Create buckets of size 10
        List<int>[] buckets = new List<int>[bucketCount];

        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach (int num in array)
        {
            int bucketIndex = (num - min) / 10;
            buckets[bucketIndex].Add(num);
        }

        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i].Sort(); // Sort each bucket
        }

        return buckets.SelectMany(b => b).ToArray(); // Concatenate all buckets
    }
}
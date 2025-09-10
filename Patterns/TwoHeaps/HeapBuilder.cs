namespace Programming.Patterns.TwoHeaps.HeapBuilder;
/*
build a heap which support:
1. insert new number.
2. extract root (remove the root and rebuild the heap)
3. Peek (return the root)
*/

public class HeapBuilder
{
    private List<int> array;
    private int type;
    /// type=0 min heap (root is the smallest), type=1 max heap
    public HeapBuilder(int type)
    {
        if (type != 0 && type != 1)
            throw new ArgumentException("Type must be 0 (min-heap) or 1 (max-heap).");
        this.type = type;
        array = [];
    }
    public void Insert(int num)
    {
        array.Add(num);
        var index = array.Count - 1;
        BubbleUp(index);
    }

    private void BubbleUp(int index)
    {
        while (index > 0)
        {
            var parent = (index - 1) / 2;
            if (type == 0) // min heap
            {
                if (array[index] >= array[parent]) break; // Stop if current >= parent
            }
            else // max heap
            {
                if (array[index] <= array[parent]) break; // Stop if current <= parent
            }

            (array[index], array[parent]) = (array[parent], array[index]);
            index = parent;
        }
    }

    public int ExtractRoot()
    {
        if (array.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        var root = array[0];
        array[0] = array[array.Count - 1];
        array.RemoveAt(array.Count - 1);

        if (array.Count > 0) // Only bubble down if heap is not empty
            BubbleDown(0);

        return root;
    }

    private void BubbleDown(int index)
    {
        while (true)
        {
            var current_index = index;
            var left_child = 2 * current_index + 1;
            var right_child = left_child + 1;
            var target_index = current_index;

            if (type == 0) // min heap
            {
                if (left_child < array.Count && array[left_child] < array[target_index])
                    target_index = left_child;
                if (right_child < array.Count && array[right_child] < array[target_index])
                    target_index = right_child;
            }
            else // max heap
            {
                if (left_child < array.Count && array[left_child] > array[target_index])
                    target_index = left_child;
                if (right_child < array.Count && array[right_child] > array[target_index])
                    target_index = right_child;
            }

            if (target_index == current_index) break;

            (array[target_index], array[current_index]) = (array[current_index], array[target_index]);
            index = target_index;
        }
    }

    public int? Peek()
    {
        if (array.Count > 0)
            return array[0];
        return null;
    }

    public int[] Get()
    {
        return array.ToArray();
    }
}
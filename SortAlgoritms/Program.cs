// See https://aka.ms/new-console-template for more information
Console.WriteLine("| 算法     | 平均复杂度     | 最坏复杂度     | 稳定性 | 适用场景          |");
Console.WriteLine("|----------|----------------|----------------|--------|-------------------|");
Console.WriteLine("| 冒泡排序 | O(n^2)         | O(n^2)         | 稳定   | 小规模数据        |");
Console.WriteLine("| 选择排序 | O(n^2)         | O(n^2)         | 不稳定 | 内存交换少        |");
Console.WriteLine("| 插入排序 | O(n^2)         | O(n^2)         | 稳定   | 基本有序数据      |");
Console.WriteLine("| 希尔排序 | O(n^{1.3})     | O(n^2)         | 不稳定 | 中等规模数据      |");
Console.WriteLine("| 归并排序 | O(nlogn)       | O(nlogn)       | 稳定   | 大规模、外部排序  |");
Console.WriteLine("| 快速排序 | O(nlogn)       | O(n^2)         | 不稳定 | 实践中最常用      |");
Console.WriteLine("| 堆排序   | O(nlogn)       | O(nlogn)       | 不稳定 | 内存有限场景      |");
Console.WriteLine("| 计数排序 | O(n+k)         | O(n+k)         | 稳定   | 整数且范围小      |");
Console.WriteLine("| 桶排序   | O(n+k)         | O(n^2)         | 稳定   | 均匀分布数据      |");
Console.WriteLine("| 基数排序 | O(nk)          | O(nk)          | 稳定   | 整数/字符串       |");

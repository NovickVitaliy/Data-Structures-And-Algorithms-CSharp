using System.Collections.Concurrent;

namespace DSA.SortingAlgorithms;

public class QuickSort : ISortingAlgorithm
{
    public void Sort(int[] arr)
    {
        var start = 0;
        var end = arr.Length - 1;

        Sort(arr, start, end);
    }

    private void Sort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int pivot = Partition(arr, start, end);

            Sort(arr,start, pivot - 1);
            Sort(arr, pivot + 1, end);
        }
    }

    private int Partition(int[] arr, int start, int end)
    {
        var pivot = arr[end];
        int i = start - 1;

        for (int j = start; j < end; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        i++;
        (arr[i], arr[end]) = (arr[end], arr[i]);
        return i;
    }
}
namespace DSA.SortingAlgorithms;
/// <summary>
/// Sorting algorithm using Bubble Sort
/// Worst Case: O(n^2)
/// Average Case: O(n^2)
/// Best Case: O(n)
/// </summary>
/// <typeparam name="T"></typeparam>
public class BubbleSort<T> where T : IComparable
{
    public void Sort(T[] arr)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j].CompareTo(arr[j + 1]) > 0)
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }
}
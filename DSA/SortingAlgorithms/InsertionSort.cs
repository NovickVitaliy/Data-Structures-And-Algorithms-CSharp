namespace DSA.SortingAlgorithms;
/// <summary>
/// Sorting algorithm using Insertion Sort
/// Worst Case: O(n^2)
/// Average Case: O(n^2)
/// Best Case: O(n)
/// </summary>
/// <typeparam name="T"></typeparam>
public class InsertionSort<T> where T : IComparable
{
    public void Sort(T[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            T value = arr[i];
            int index = i;

            while (index > 0 && arr[index - 1].CompareTo(value) > 0)
            {
                arr[index] = arr[index - 1];
                index--;
            }

            arr[index] = value;
        }
    }
}
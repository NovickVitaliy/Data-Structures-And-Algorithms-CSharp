namespace DSA.SortingAlgorithms;

/// <summary>
/// Sorting algorithm using Selection Sort
/// Worst Case: O(n^2)
/// Average Case: O(n^2)
/// Best Case: O(n^2)
/// </summary>
/// <typeparam name="T"></typeparam>
public class SelectionSort<T> where T : IComparable
{
    public void Sort(T[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            int index = i;
            
            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[j].CompareTo(arr[index]) < 0)
                {
                    index = j;
                }
            }
            
            (arr[i], arr[index]) = (arr[index], arr[i]);
        }
    }
}
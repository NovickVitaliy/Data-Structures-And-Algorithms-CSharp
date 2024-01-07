using DSA.SortingAlgorithms;

int[] arr = { 6, 3, 2, 6, 5, 4, 5, 3, 2, 3, 4, 8, 9, 7, 6, 9, 9, 7 };
InsertionSort<int> insertionSort = new InsertionSort<int>();

insertionSort.Sort(arr);
Console.WriteLine();
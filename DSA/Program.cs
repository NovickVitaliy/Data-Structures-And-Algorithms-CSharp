using DSA.SortingAlgorithms;

var quickSort = new QuickSort();

int[] arr = [5,4,3,6,3,1,7,6,8,9,5,4,5,6,7,4];
Console.WriteLine("Unsorted");
foreach (var i in arr)
{
    Console.WriteLine(i);
}

quickSort.Sort(arr);
Console.WriteLine("Sorted");
foreach (var i in arr)
{
    Console.WriteLine(i);
}



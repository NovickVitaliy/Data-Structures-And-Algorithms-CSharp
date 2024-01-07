using DSA.DataStructures;
using DSA.SortingAlgorithms;

Array<int> ints = new Array<int>();
ints.Add(5);
ints.Add(2);
ints.Add(7);
ints.Add(1);
ints.Add(999, 3);
ints.Delete(2);
foreach (var i in ints)
{
    Console.WriteLine(i);
}


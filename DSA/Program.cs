using DSA.DataStructures;
using DSA.DataStructures.LinkedList;
using DSA.DataStructures.LinkedList.DoubleLinkedList;
using DSA.DataStructures.Stack.StackBasedOnArray;
using DSA.DataStructures.Stack.StackBasedOnLinkedList;
using DSA.SortingAlgorithms;


ArrayBasedStack<int> ints = new ArrayBasedStack<int>(4);
ints.Push(1);
ints.Push(2);
ints.Push(3);
ints.Push(4);
bool exists = ints.Contains(e => e == 3);
Console.WriteLine(exists);
var data = ints.Peek();
Console.WriteLine(data);
data = ints.Peek();
Console.WriteLine(data);
data = ints.Peek();
Console.WriteLine(data);
data = ints.Peek();
Console.WriteLine(data);
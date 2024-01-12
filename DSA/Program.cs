using DSA.DataStructures;
using DSA.DataStructures.LinkedList;
using DSA.DataStructures.LinkedList.DoubleLinkedList;
using DSA.DataStructures.Stack.StackBasedOnLinkedList;
using DSA.SortingAlgorithms;


LinkedListBasedStack<int> ints = new LinkedListBasedStack<int>();
ints.Push(1);
ints.Push(2);
ints.Push(3);
ints.Push(4);
var data = ints.Pop();
Console.WriteLine(data);
data = ints.Pop();
Console.WriteLine(data);
data = ints.Pop();
Console.WriteLine(data);
data = ints.Pop();
Console.WriteLine(data);
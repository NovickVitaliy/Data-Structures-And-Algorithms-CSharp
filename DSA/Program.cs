using DSA.DataStructures;
using DSA.DataStructures.LinkedList;
using DSA.DataStructures.LinkedList.DoubleLinkedList;
using DSA.DataStructures.Queue;
using DSA.DataStructures.Queue.QueueBasedOnLinkedList;
using DSA.DataStructures.Stack.StackBasedOnArray;
using DSA.DataStructures.Stack.StackBasedOnLinkedList;
using DSA.SortingAlgorithms;


LinkedListBasedQueue<int> ints = new LinkedListBasedQueue<int>();
ints.Enqueue(1);
ints.Enqueue(2);
ints.Enqueue(3);
ints.Enqueue(4);
ints.Enqueue(5);
var elem = ints.Dequeue();
Console.WriteLine(elem);
elem = ints.Dequeue();
Console.WriteLine(elem);
elem = ints.Dequeue();
Console.WriteLine(elem);
elem = ints.Dequeue();
Console.WriteLine(elem);
elem = ints.Dequeue();
Console.WriteLine(elem);
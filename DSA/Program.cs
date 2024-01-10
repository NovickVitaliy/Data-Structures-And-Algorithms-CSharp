using DSA.DataStructures;
using DSA.DataStructures.LinkedList;
using DSA.DataStructures.LinkedList.DoubleLinkedList;
using DSA.SortingAlgorithms;


DoubleLinkedList<int> list = new DoubleLinkedList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(9, 0);
list.Add(99, 2);
list.Add(999, 4);
var doubleLinkedListNode = list.GetNode(val => val == 999);
Console.WriteLine();


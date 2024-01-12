namespace DSA.DataStructures.Stack.StackBasedOnLinkedList;

public class LinkedListBasedStackNode<T>
{
    public LinkedListBasedStackNode(T data)
    {
        Data = data;
    }
    
    public T Data { get; set; }
    public LinkedListBasedStackNode<T> Next { get; set; }
}
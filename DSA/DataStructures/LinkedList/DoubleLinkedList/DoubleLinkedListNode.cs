namespace DSA.DataStructures.LinkedList.DoubleLinkedList;

public class DoubleLinkedListNode<T>
{
    public DoubleLinkedListNode(T data, DoubleLinkedListNode<T> previous = null, DoubleLinkedListNode<T> next = null)
    {
        Data = data;
    }
    
    public DoubleLinkedListNode<T> Previous { get; set; }
    public DoubleLinkedListNode<T> Next { get; set; }
    public T Data { get; set; }
}
namespace DSA.DataStructures.LinkedList;

public class SingleLinkedListNode<T>
{
    public SingleLinkedListNode(T data, SingleLinkedListNode<T>? next = null)
    {
        Data = data;
        Next = next;
    }

    public T Data { get; set; }
    public SingleLinkedListNode<T>? Next { get; set; }
}
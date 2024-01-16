namespace DSA.DataStructures.Queue.QueueBasedOnLinkedList;

public class LinkedListBasedQueue<T>
{
    private LinkedListQueueNode<T> _front = null;
    private LinkedListQueueNode<T> _back = null;
    private int _count = 0;


    public void Enqueue(T item)
    {
        _count++;
        var newNode = new LinkedListQueueNode<T>() { Data = item };
        if (_front == null)
        {
            _front = newNode;
            _back = _front;
        }

        _back.Next = newNode;
        _back = newNode;
    }

    public T Dequeue()
    {
        if (_count == 0)
        {
            throw new IndexOutOfRangeException("Queue is empty");
        }

        var nodeToDequeue = _front;
        _front = _front.Next;
        _count--;
        return nodeToDequeue.Data;
    }

    public T Front()
    {
        if (_count == 0)
        {
            throw new IndexOutOfRangeException("Queue is empty");
        }

        return _front.Data;
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }

    public int Count()
    {
        return _count;
    }
}
namespace DSA.DataStructures.Queue;

public class ArrayBasedQueue<T>
{
    private T[] _queue;
    private int _size;
    private int _front;
    private int _back;
    private int _count;
    
    public ArrayBasedQueue(int size)
    {
        _size = size;
        _queue = new T[size];
        _front = 0;
        _back = 0;
        _count = 0;
    }


    public void Enqueue(T item)
    {
        if (_back == _size)
        {
            throw new IndexOutOfRangeException("Queue is full");
        }

        _count++;
        _queue[_back++] = item;
    }

    public T Dequeu()
    {
        if (_count == 0 || _front > _back)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        var itemToReturn = _queue[_front++];
        _count--;
        return itemToReturn;
    }

    public T Front()
    {
        if (_count == 0 || _front > _back)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return _queue[_front];
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
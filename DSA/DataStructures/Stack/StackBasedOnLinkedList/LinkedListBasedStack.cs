namespace DSA.DataStructures.Stack.StackBasedOnLinkedList;

public class LinkedListBasedStack<T>
{
    public int Size { get; private set; }
    private LinkedListBasedStackNode<T> _head;
    
    public void Push(T data)
    {
        Size++;
        if (_head == null)
        {
            _head = new LinkedListBasedStackNode<T>(data);
            return;
        }

        var newNode = new LinkedListBasedStackNode<T>(data)
        {
            Next = _head
        };
        _head = newNode;
    }

    public T Pop()
    {
        if (Size <= 0)
        {
            throw new Exception($"Stack is empty");
        }

        var data = _head.Data;
        _head = _head.Next;
        Size--;
        return data;
    }

    public T Peek()
    {
        if (Size <= 0)
        {
            throw new Exception($"Stack is empty");
        }

        return _head.Data;
    }

    public void Clear()
    {
        _head = null;
        Size = 0;
    }

    public bool Contains(Predicate<T> predicate)
    {
        if (Size <= 0)
        {
            throw new Exception($"Stack is empty");
        }

        var runner = _head;

        while (runner != null)
        {
            if (predicate(runner.Data))
            {
                return true;
            }

            runner = runner.Next;
        }

        return false;
    }
}
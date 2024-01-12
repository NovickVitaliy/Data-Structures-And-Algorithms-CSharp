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

        var runner = _head;
        while (runner.Next != null)
        {
            runner = runner.Next;
        }

        runner.Next = new LinkedListBasedStackNode<T>(data);
    }

    public T Pop()
    {
        if (Size <= 0)
        {
            throw new Exception($"Stack is empty");
        }

        LinkedListBasedStackNode<T> previous = null;
        var runner = _head;

        while (runner.Next != null)
        {
            previous = runner;
            runner = runner.Next;
        }

        Size--;
        var data = runner.Data;
        previous.Next = null;
        return data;
    }

    public T Peek()
    {
        if (Size <= 0)
        {
            throw new Exception($"Stack is empty");
        }

        var runner = _head;

        while (runner.Next != null)
        {
            runner = runner.Next;
        }

        return runner.Data;
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
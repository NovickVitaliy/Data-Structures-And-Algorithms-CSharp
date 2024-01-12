namespace DSA.DataStructures.Stack.StackBasedOnArray;

public class ArrayBasedStack<T>
{
    private int _top = -1;
    private int _size = 0;
    private T[] _stack;
    public ArrayBasedStack(int size)
    {
        _size = size;
        _stack = new T[size];
    }

    public int Count => _top;
    
    public void Push(T data)
    {
        if (_top >= _size)
        {
            throw new StackOverflowException();
        }

        _stack[++_top] = data;
    }

    public T Pop()
    {
        if (_top < 0)
        {
            throw new IndexOutOfRangeException();
        }

        var data = _stack[_top--];
        return data;
    }

    public T Peek()
    {
        if (_top <= 0)
        {
            throw new IndexOutOfRangeException();
        }

        return _stack[_top];
    }

    public void Clear()
    {
        _top = -1;
    }

    public bool Contains(Predicate<T> predicate)
    {
        for (int i = 0; i <= _top; ++i)
        {
            if(predicate(_stack[i]))
            {
                return true;
            }
        }

        return false;
    }
}
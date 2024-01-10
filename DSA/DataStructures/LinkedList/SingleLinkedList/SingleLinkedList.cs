using System.Collections;

namespace DSA.DataStructures.LinkedList;

public class SingleLinkedList<T> : IEnumerable<T>
{
    private SingleLinkedListNode<T> _head;
    private int _size = 0;

    public int Size => _size;

    public void Add(T data)
    {
        _size++;
        if (_head == null)
        {
            _head = new SingleLinkedListNode<T>(data);
            return;
        }

        var runner = _head;
        while (runner.Next != null)
        {
            runner = runner.Next;
        }

        runner.Next = new SingleLinkedListNode<T>(data);
    }

    public void Add(T data, int index)
    {
        if (index > _size || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        SingleLinkedListNode<T> newNode = new SingleLinkedListNode<T>(data);
        _size++;
        if (index == 0)
        {
            newNode.Next = _head;
            _head = newNode;
        }
        else
        {
            SingleLinkedListNode<T> previous = null;
            var runner = _head;
            while (index != 0)
            {
                previous = runner;
                runner = runner.Next;
                index--;
            }

            previous.Next = newNode;
            newNode.Next = runner;
        }
    }

    public void Delete(int index)
    {
        if (index >= _size || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        if (index == 0)
        {
            DeleteFromStart();
        }

        if (index == _size - 1)
        {
            DeleteFromEnd();
        }

        SingleLinkedListNode<T> previous = null;
        var runner = _head;

        while (index != 0)
        {
            previous = runner;
            runner = runner.Next;
            index--;
        }

        previous.Next = runner.Next;
        _size--;
    }

    public void DeleteFromStart()
    {
        if (_head != null)
        {
            _head = _head.Next;
            _size--;
        }
    }

    public void DeleteFromEnd()
    {
        if (_head != null)
        {
            _size--;
            var runner = _head;
            while (runner.Next.Next != null)
            {
                runner = runner.Next;
            }

            runner.Next = null;
        }
    }

    public T ElementAt(int index)
    {
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException();
        }

        var runner = _head;
        while (index != 0)
        {
            runner = runner.Next;
            index--;
        }

        return runner.Data;
    }

    public bool Contains(T data)
    {
        var runner = _head;
        while (runner != null)
        {
            if (runner.Data.Equals(data))
            {
                return true;
            }

            runner = runner.Next;
        }

        return false;
    }

    public void Modify(int index, T newData)
    {
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException();
        }

        var runner = _head;

        while (index != 0)
        {
            index--;
            runner = runner.Next;
        }

        runner.Data = newData;
    }

    public void Sort()
    {
        if (!typeof(T).GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IComparable<>)))
        {
            throw new InvalidOperationException($"Cannot perform sort operation on type '{typeof(T).Name}'. Implement IComparable<{typeof(T).Name}> in order to perform sort operation.");
        }
        if (_size is 0 or 1)
        {
            return;
        }

        SingleLinkedListNode<T> newHead = PopSmallestNode();
        var runner = newHead;
        SingleLinkedListNode<T> nodeToAdd = null;
        for ( ; (nodeToAdd = PopSmallestNode())!= null;)
        {
            runner.Next = nodeToAdd;
            runner = runner.Next;
        }

        _head = newHead;
    }

    private SingleLinkedListNode<T> PopSmallestNode()
    {
        if (_head == null)
        {
            return null;
        }
        if (_head.Next == null)
        {
            var node = _head;
            _head = null;
            return node;
        }
        if (_head != null)
        {
            SingleLinkedListNode<T> smallestNode = _head;
            IComparable<T> comparableData = (IComparable<T>)smallestNode.Data;
            SingleLinkedListNode<T> previous = null;
            var runner = _head;
            while (runner != null)
            {
                if (comparableData.CompareTo(runner.Data) > 0)
                {
                    smallestNode = runner;
                    comparableData = (IComparable<T>)runner.Data;
                }
                runner = runner.Next;
            }

            runner = _head;
            while (runner.Next != null)
            {
                if (runner == smallestNode)
                {
                    if (previous == null)
                    {
                        _head = runner.Next;
                        smallestNode.Next = null;
                        return smallestNode;
                    }
                    else
                    {
                        previous.Next = runner.Next;
                        smallestNode.Next = null;
                        return smallestNode;
                    }
                }

                previous = runner;
                runner = runner.Next;
            }
        }

        return null;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var runner = _head;
        while (runner != null)
        {
            yield return runner.Data;
            runner = runner.Next;
        }
    }

    public void Reverse()
    {
        List<SingleLinkedListNode<T>> nodes = new List<SingleLinkedListNode<T>>();

        var runner = _head;
        while (runner != null)
        {
            nodes.Add(runner);
            runner = runner.Next;
        }

        SingleLinkedListNode<T> newHead = nodes[^1];
        runner = newHead;
        for (int i = nodes.Count - 2; i >= 0; i--)
        {
            runner.Next = nodes[i];
            runner = runner.Next;
        }

        runner.Next = null;
        _head = newHead;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}
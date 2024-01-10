using System.Collections;
using System.Linq.Expressions;

namespace DSA.DataStructures.LinkedList.DoubleLinkedList;

public class DoubleLinkedList<T> : IEnumerable<T>
{
    private DoubleLinkedListNode<T> _head;

    public DoubleLinkedList()
    {
    }

    public int Size { get; private set; }

    public void Add(T data)
    {
        if (_head == null)
        {
            _head = new DoubleLinkedListNode<T>(data);
        }
        else
        {
            var runner = _head;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }

            var newNode = new DoubleLinkedListNode<T>(data);
            runner.Next = newNode;
            newNode.Previous = runner;
        }

        Size++;
    }

    public void Add(T data, int index)
    {
        if (index < 0 || index >= Size)
        {
            throw new IndexOutOfRangeException();
        }

        var runner = _head;
        while (index != 0)
        {
            index--;
            runner = runner.Next;
        }

        var newNode = new DoubleLinkedListNode<T>(data);
        if (runner.Previous == null)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }
        else
        {
            runner.Previous.Next = newNode;
            newNode.Previous = runner.Previous;
            runner.Previous = newNode;
            newNode.Next = runner;
        }

        Size++;
    }

    public void AddAfter(T data, DoubleLinkedListNode<T> node)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        var runner = _head;
        while (runner != node)
        {
            runner = runner.Next;
        }

        var newNode = new DoubleLinkedListNode<T>(data);
        newNode.Previous = runner;
        newNode.Next = runner.Next;
        runner.Next = newNode;
        Size++;
    }

    public void AddBefore(T data, DoubleLinkedListNode<T> node)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        var runner = _head;
        while (runner != node)
        {
            runner = runner.Next;
        }

        var newNode = new DoubleLinkedListNode<T>(data);

        if (runner.Previous == null)
        {
            _head.Previous = newNode;
            _head = newNode;
        }
        else
        {
            node.Previous.Next = newNode;
            newNode.Next = node;
            newNode.Previous = node.Previous;
            node.Previous = newNode;
        }


        Size++;
    }

    public void DeleteNode(DoubleLinkedListNode<T> node)
    {
        if (node == null)
            return;

        var runner = _head;

        while (runner != null)
        {
            if (runner == node)
            {
                if (runner.Previous == null)
                {
                    _head = _head.Next;
                }
                else
                {
                    runner.Previous.Next = runner.Next;
                    runner.Next.Previous = runner.Previous;
                }

                Size--;
            }

            runner = runner.Next;
        }
    }

    public DoubleLinkedListNode<T> GetNode(Predicate<T> predicate)
    {
        var runner = _head;
        while (runner != null)
        {
            if (predicate(runner.Data))
            {
                return runner;
            }

            runner = runner.Next;
        }

        return null;
    }

    public bool ValuExists(Predicate<T> predicate)
    {
        var runner = _head;
        while (runner != null)
        {
            if (predicate(runner.Data))
            {
                return true;
            }
        }

        return false;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }

    public void Clear()
    {
        _head = null;
        Size = 0;
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

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
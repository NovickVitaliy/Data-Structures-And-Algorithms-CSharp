using System.Collections;

namespace DSA.DataStructures;

public class Array<T> : IEnumerable<T>
{
    private T[] _array;

    public Array()
    {
        _array = Array.Empty<T>();
    }

    public Array(int size)
    {
        Size = size;
        _array = new T[size];
    }

    public int Size { get; private set; }

    public void Add(T element)
    {
        var oldArr = _array;
        _array = new T[_array.Length + 1];
        for (var i = 0; i < oldArr.Length; i++)
        {
            _array[i] = oldArr[i];
        }

        _array[^1] = element;
        Size++;
    }

    public void Add(T element, int index)
    {
        if (index > Size || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        var oldArr = _array;
        _array = new T[_array.Length + 1];
        Size++;
        for (var i = 0; i < index; i++)
        {
            _array[i] = oldArr[i];
        }

        _array[index] = element;
        
        for (var i = index + 1; i < _array.Length; i++)
        {
            _array[i] = oldArr[i - 1];
        }
    }

    public void Delete(int index)
    {
        if (index >= Size || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        var oldArr = _array;
        _array = new T[oldArr.Length - 1];
        Size--;
        for (var i = 0; i < index; i++)
        {
            _array[i] = oldArr[i];
        }
        for (var i = index + 1; i < oldArr.Length; i++)
        {
            _array[i - 1] = oldArr[i];
        }
    }

    public T ElementAt(int index)
    {
        if (index >= Size || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        return _array[index];
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var t in _array)
        {
            yield return t;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
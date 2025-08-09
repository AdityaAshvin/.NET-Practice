using System;
using System.Buffers;
using System.Collections.ObjectModel;

public class MyList<T>
{
    private T[] list = Array.Empty<T>();
    private int len;

    public void Add(T item)
    {
        Array.Resize(ref list, len + 1);
        list[len] = item;
        len += 1;

        Console.WriteLine("item added succesfully");
    }

    public T Remove(int index)
    {
        T[] newList = new T[len - 1];
        T removedItem = list[index];
        len -= 1;

        int i = 0;
        int j = 0;
        while (i < list.Length)
        {
            if (i != index)
            {
                newList[j] = list[i];
                j++;
            }

            i++;
        }

        list = newList;

        return removedItem;
    }

    public bool Contains(T element)
    {
        var comparer = EqualityComparer<T>.Default;

        foreach (var ele in list)
        {
            if (comparer.Equals(ele, element))
            {
                Console.WriteLine($"item found {ele}");
                return true;
            }
        }
        Console.WriteLine($"item not found {element}");
        return false;
    }

    public void Clear()
    {
        Array.Clear(list);
        len = 0;
    }

    public void InsertAt(T element, int index)
    {
        Array.Resize(ref list, len + 1);

        for (int i = len; i > index; i--)
        {
            list[i] = list[i - 1];
        }

        list[index] = element;
        len += 1;
    }

    public void DeleteAt(int index)
    {
        for (int i = index; i < len - 1; i++)
        {
            list[i] = list[i + 1];
        }

        list[len - 1] = default!;

        len--;

        Array.Resize(ref list, len);
    }

    public T Find(int index)
    {
        return list[index];
    }
}
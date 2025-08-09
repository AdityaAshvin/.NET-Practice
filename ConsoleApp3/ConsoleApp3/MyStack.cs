using System;

public class MyStack<T>
{
    private List<T> stack = new List<T>();
    private int len;

    public int Count()
    {
        return len;
    }

    public void Push(T item)
    {
        stack.Add(item);
        len += 1;

        Console.WriteLine("added item from stack success");
    }

    public T Pop()
    {
        T popItem = stack[len - 1];
        stack.RemoveAt(len - 1);
        len -= 1;

        Console.WriteLine("popped item from stack success");

        return popItem;
    }
}
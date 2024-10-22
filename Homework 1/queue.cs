using System;
using System.Collections.Generic;

public class CustomQueue<T>
{
    private List<T> _queue;

    public CustomQueue()
    {
        _queue = new List<T>();
    }
    public void Enqueue(T item)
    {
        _queue.Add(item);
    }

    public T Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        T value = _queue[0];
        _queue.RemoveAt(0);
        return value;
    }

    public T Peek()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        return _queue[0];
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public int Count()
    {
        return _queue.Count;
    }
    public void Clear()
    {
        _queue.Clear();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CustomQueue<int> queue = new CustomQueue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Peek: " + queue.Peek()); 

        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Dequeue: " + queue.Dequeue()); 

        Console.WriteLine("Is Empty: " + queue.IsEmpty()); 

        Console.WriteLine("Count: " + queue.Count()); 

        queue.Clear();
        Console.WriteLine("Count after clearing: " + queue.Count()); 
    }
}

//Recursive Insertion Sort
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        RecursiveInsertionSort(arr, arr.Length);
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }

    static void RecursiveInsertionSort(int[] arr, int n)
    {
        
        if (n <= 1)
            return;

        RecursiveInsertionSort(arr, n - 1);

        // Insert the last element at the correct position
        int last = arr[n - 1];
        int j = n - 2;

      
        while (j >= 0 && arr[j] > last)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = last;
    }
}



//Custom Queue Implementation
using System;
using System.Collections.Generic;

class CustomQueue<T>
{
    private List<T> queue = new List<T>();

    // Enqueue: add an item to the queue
    public void Enqueue(T item)
    {
        queue.Add(item);
    }

    // Dequeue: remove and return the item at the front of the queue
    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Dequeue from an empty queue");

        T value = queue[0];
        queue.RemoveAt(0);
        return value;
    }

    // Peek: return the item at the front without removing it
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Peek from an empty queue");

        return queue[0];
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return queue.Count == 0;
    }

    // Get the size of the queue
    public int Size()
    {
        return queue.Count;
    }

    // ToString method for display
    public override string ToString()
    {
        return string.Join(", ", queue);
    }
}

// Example usage
class Program
{
    static void Main()
    {
        CustomQueue<int> customQueue = new CustomQueue<int>();
        customQueue.Enqueue(1);
        customQueue.Enqueue(2);
        customQueue.Enqueue(3);

        Console.WriteLine("Queue: " + customQueue);
        Console.WriteLine("Dequeue: " + customQueue.Dequeue());
        Console.WriteLine("Queue after dequeue: " + customQueue);
        Console.WriteLine("Peek: " + customQueue.Peek());
        Console.WriteLine("Size of queue: " + customQueue.Size());
    }
}



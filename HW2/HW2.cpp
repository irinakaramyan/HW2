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
        // Base case: if the array has one or no elements, it's sorted
        if (n <= 1)
            return;

        // Sort the first n-1 elements
        RecursiveInsertionSort(arr, n - 1);

        // Insert the last element at the correct position
        int last = arr[n - 1];
        int j = n - 2;

        // Move elements of arr[0..n-2], that are greater than last,
        // to one position ahead of their current position
        while (j >= 0 && arr[j] > last)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = last;
    }
}


using System;

class RecursiveInsertionSort
{
    static void InsertionSortRecursive(int[] arr, int n)
    {
        if (n <= 1)
            return;

        InsertionSortRecursive(arr, n - 1);

        int last = arr[n - 1];
        int j = n - 2;

        while (j >= 0 && arr[j] > last)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = last;
    }

    static void Main(string[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        int n = arr.Length;

        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(" ", arr));

        InsertionSortRecursive(arr, n);

        Console.WriteLine("Sorted Array:");
        Console.WriteLine(string.Join(" ", arr));
    }
}

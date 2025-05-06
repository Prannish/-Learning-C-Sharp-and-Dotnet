using System;

class Program
{
    static void Main()
    {
        // Step 1: Create and initialize the array
        int[] numbers = { 23, 12, 45, 6, 78, 1, 34 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        // Step 2: Sort the array in ascending order
        Array.Sort(numbers);
        Console.WriteLine("\nArray in Ascending Order:");
        PrintArray(numbers);

        // Step 3: Sort in descending order using Array.Reverse()
        Array.Reverse(numbers);
        Console.WriteLine("\nArray in Descending Order:");
        PrintArray(numbers);
    }

    // Helper method to print array
    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
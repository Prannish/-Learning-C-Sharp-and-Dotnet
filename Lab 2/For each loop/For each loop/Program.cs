using System;

class Program
{
    static void Main()
    {
        // Declare and initialize an array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Elements in the array:");

        // Use foreach loop to iterate through the array
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Loop completed.");
    }
}
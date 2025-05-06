using System;

class Program
{
    // Method with no parameters
    static void Display()
    {
        Console.WriteLine("Display with no parameters.");
    }

    // Method with one integer parameter
    static void Display(int number)
    {
        Console.WriteLine("Display with one integer: " + number);
    }

    // Method with one string parameter
    static void Display(string text)
    {
        Console.WriteLine("Display with one string: " + text);
    }

    // Method with two parameters
    static void Display(string text, int number)
    {
        Console.WriteLine($"Display with string and int: {text}, {number}");
    }

    static void Main()
    {
        // Call all overloaded methods
        Display();
        Display(100);
        Display("Hello");
        Display("Score", 95);
    }
}

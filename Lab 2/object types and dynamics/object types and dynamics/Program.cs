using System;

class Program
{
    static void Main()
    {
        // Using object type
        object obj1 = 42;            // Boxing an int
        object obj2 = "Hello";       // Storing a string
        object obj3 = 3.14;          // Storing a double

        Console.WriteLine("Object values:");
        Console.WriteLine("obj1: " + obj1);
        Console.WriteLine("obj2: " + obj2);
        Console.WriteLine("obj3: " + obj3);

        // Need casting to access specific methods/properties
        string upper = ((string)obj2).ToUpper();
        Console.WriteLine("Uppercase of obj2: " + upper);

        Console.WriteLine();

        // Using dynamic type
        dynamic dyn1 = 10;
        dynamic dyn2 = "world";
        dynamic dyn3 = 4.5;

        Console.WriteLine("Dynamic values:");
        Console.WriteLine("dyn1 + 5 = " + (dyn1 + 5));      // Treated as int
        Console.WriteLine("dyn2.ToUpper() = " + dyn2.ToUpper());  // Treated as string
        Console.WriteLine("dyn3 * 2 = " + (dyn3 * 2));      // Treated as double

        // No compile-time checking for dynamic
        // But this will throw runtime error:
        // Console.WriteLine(dyn1.NonExistentMethod()); // Uncomment to see error
    }
}

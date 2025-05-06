using System;

// Sealed class
sealed class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Square(int x)
    {
        return x * x;
    }
}

// This will cause a compile-time error
// class AdvancedCalculator : Calculator { }

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Addition: " + calc.Add(5, 3));
        Console.WriteLine("Square: " + calc.Square(4));

        // Uncommenting below line will give error:
        // "cannot derive from sealed type 'Calculator'"
        // AdvancedCalculator adv = new AdvancedCalculator();
    }
}

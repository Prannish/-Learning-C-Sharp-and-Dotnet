using System;

class Program
{
    static void Main()
    {
        // 1. Calling a void method
        SayHello();

        // 2. Calling a method with parameters
        PrintSum(5, 10);

        // 3. Calling a method with return value
        int result = GetRandomNumber();
        Console.WriteLine("Random number returned: " + result);

        // 4. Calling a method with parameters and return value
        int product = Multiply(4, 5);
        Console.WriteLine("Product returned: " + product);

        // 5. Calling a static method
        ShowMessage();

        // 6. Calling an instance (non-static) method
        Program obj = new Program();
        obj.ShowInfo("C#");
    }

    // 1. Void method
    static void SayHello()
    {
        Console.WriteLine("Hello from a void method!");
    }

    // 2. Method with parameters
    static void PrintSum(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    // 3. Method with return value
    static int GetRandomNumber()
    {
        return new Random().Next(1, 100);
    }

    // 4. Method with parameters and return value
    static int Multiply(int x, int y)
    {
        return x * y;
    }

    // 5. Static method
    static void ShowMessage()
    {
        Console.WriteLine("This is a static method.");
    }

    // 6. Instance method
    void ShowInfo(string topic)
    {
        Console.WriteLine("Learning " + topic + " methods.");
    }
}

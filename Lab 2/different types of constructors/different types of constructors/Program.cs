using System;

class Student
{
    public string Name;
    public int Age;

    // 1. Default Constructor
    public Student()
    {
        Name = "Unknown";
        Age = 0;
        Console.WriteLine("Default constructor called.");
    }

    // 2. Parameterized Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Parameterized constructor called.");
    }

    // 3. Copy Constructor
    public Student(Student other)
    {
        Name = other.Name;
        Age = other.Age;
        Console.WriteLine("Copy constructor called.");
    }

    // 4. Static Constructor
    static Student()
    {
        Console.WriteLine("Static constructor called (runs only once).");
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Static constructor is called automatically before any instance is created

        // Default constructor
        Student s1 = new Student();
        s1.Display();

        Console.WriteLine();

        // Parameterized constructor
        Student s2 = new Student("Alice", 21);
        s2.Display();

        Console.WriteLine();

        // Copy constructor
        Student s3 = new Student(s2);
        s3.Display();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter nth term: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, next;
            Console.Write("Fibonacci Series: 1");
            for (int i = 1; i < n; i++)
            {
                Console.Write($", {a + b}");
                next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

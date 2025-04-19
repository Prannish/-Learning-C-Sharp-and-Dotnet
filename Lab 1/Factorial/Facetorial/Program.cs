using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facetorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            Console.WriteLine($"Factorial: {fact}");
            Console.ReadKey();
        }
    }
}

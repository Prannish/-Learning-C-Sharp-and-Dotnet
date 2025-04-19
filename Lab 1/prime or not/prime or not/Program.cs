using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = num > 1;
            for (int i = 2; i * i <= num; i++)
                if (num % i == 0)
                    isPrime = false;
            Console.WriteLine(isPrime ? "Prime Number" : "Not a Prime Number");
            Console.ReadKey();
        }
    }
}

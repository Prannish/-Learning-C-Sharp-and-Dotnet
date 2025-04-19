using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()), sum = 0, temp = num;
            while (temp > 0)
            {
                int d = temp % 10;
                sum += d * d * d;
                temp /= 10;
            }
            Console.WriteLine(num == sum ? "Armstrong Number" : "Not an Armstrong Number");
            Console.ReadKey();
        }
    }
}

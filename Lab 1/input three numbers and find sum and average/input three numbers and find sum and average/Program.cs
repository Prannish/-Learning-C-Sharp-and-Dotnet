using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_three_numbers_and_find_sum_and_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            int c = Convert.ToInt32(Console.ReadLine());
            int sum= a + b + c;
            double average = (a + b + c) / 2;
            Console.WriteLine("Sum=" + sum);
            Console.WriteLine("Average=" + average);
            Console.ReadKey();
        }
    }
}

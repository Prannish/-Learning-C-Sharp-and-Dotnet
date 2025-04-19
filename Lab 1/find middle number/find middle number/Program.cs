using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_middle_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter three different numbers: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Middle number: " + (a > b ? (a < c ? a : (b > c ? b : c)) : (b < c ? b : (a > c ? a : c))));
            Console.ReadKey();
        }
    }
}

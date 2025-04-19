using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsa_of_cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth:");
            int breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            int height = Convert.ToInt32(Console.ReadLine());
            double tsa = 2*((length * breadth) + (breadth * height) + (height * length));
            Console.WriteLine("Total Surface Area=" + tsa);
            Console.ReadKey();
        }
    }
}

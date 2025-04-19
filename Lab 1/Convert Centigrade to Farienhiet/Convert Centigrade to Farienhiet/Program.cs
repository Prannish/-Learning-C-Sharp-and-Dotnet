using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Centigrade_to_Farienhiet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit="+fahrenheit);
            Console.ReadKey();

        }
    }
}

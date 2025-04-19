using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_seconds_into_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int sec = seconds % 60;
            Console.WriteLine($"{hours} hrs {minutes} min {sec} sec");
            Console.ReadKey();
        }
    }
}

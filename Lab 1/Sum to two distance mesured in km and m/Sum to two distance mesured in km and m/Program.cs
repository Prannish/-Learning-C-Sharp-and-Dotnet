using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_to_two_distance_mesured_in_km_and_m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter point one distances in kilometer: ");
            int km1 = int.Parse(Console.ReadLine());
            Console.Write("Enter point one distances in meter: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Enter point two distances in kilometer: ");
            int km2 = int.Parse(Console.ReadLine());
            Console.Write("Enter point two distances in meter: ");
            int m2 = int.Parse(Console.ReadLine());
            int totalMeters = m1 + m2;
            int totalKm = km1 + km2 + (totalMeters / 1000);//extracts extra kilometers from meters.
            totalMeters %= 1000;
            Console.WriteLine("Total Distance: "+ totalKm +" km "+ totalMeters +" m ");
            Console.ReadKey();
        }
    }
}

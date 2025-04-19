using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_total_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter units consumed: ");
            int units = int.Parse(Console.ReadLine());
            double bill = 80;
            if (units > 20)
                bill += (Math.Min(100, units) - 20) * 7.25;
            if (units > 100)
                bill += (units - 100) * 9.50;
            Console.WriteLine($"Total bill: Rs. {bill}");
            Console.ReadKey();

        }
    }
}

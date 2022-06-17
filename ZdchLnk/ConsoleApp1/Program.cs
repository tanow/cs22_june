using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dividend, divider, remainder, quotient;
            dividend = double.Parse(Console.ReadLine());
            divider = double.Parse(Console.ReadLine());
            remainder = dividend % divider;
            quotient = (dividend / divider) - (remainder / divider);
            Console.WriteLine("Делимое {0:F0}, делитель {1:F0}, частное {2:F0}, остаток {3:F0}", dividend, divider, quotient, remainder);

        }
    }
}

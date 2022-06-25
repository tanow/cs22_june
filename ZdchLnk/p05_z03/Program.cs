using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_z03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());

            if (a <= b)
            {
                if (x >= a && x <= b)
                {
                    Console.WriteLine("{0:F0} попадает в интервал от {1:F0} до {2:F0}", x, a, b);
                }
                else
                    Console.WriteLine("{0:F0} за пределами  интервала от {1:F0} до {2:F0}", x, a, b);
             }
            else
            {
                Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой");
            }
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_z01
{
    class Program
    {
        static void Main(string[] args)
        {
            double edge, area;
            edge = double.Parse(Console.ReadLine());
            area = Math.Pow(edge, 2) * 6;
            if (edge > 0)
            {
                Console.WriteLine(area);
            }
            else
            {
                Console.WriteLine("Значение edge должно быть положительно");
            }
        }
    }
}

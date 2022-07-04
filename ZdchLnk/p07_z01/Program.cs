using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z01
{
    class Program
    {
        static void Main(string[] args)
        {
            int R, T;

            R = int.Parse(Console.ReadLine());
            T = int.Parse(Console.ReadLine());

            if (R < 0)
            {
                Console.WriteLine("Значение R должно быть неотрицательно");
            }
            if (T < 0)
            {
                Console.WriteLine("Значение T должно быть неотрицательно");
            }
            if (R >= 0 && T >= 0)
            {
                for (int i = 0; i < R; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
                for (int i = 0; i < T; i++)
                {
                    Console.Write("#");
                }
            }
        }
    }
}

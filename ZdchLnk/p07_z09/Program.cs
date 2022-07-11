using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z09
{
    class Program
    {
        static void Main(string[] args)
        {
            int W, H;

            W = int.Parse(Console.ReadLine());
            H = int.Parse(Console.ReadLine());

            if (W < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
            }
            if (H < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
            }
            if (W >= 0 && H >= 0)
            {
                Console.Write(" ");
                for (int i = 0; i < W; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                for (int i = 0; i < H; i++)
                {
                    Console.Write(i);
                    for (int y = 0; y < W; y++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("|\n");
                }
                Console.Write(" ");
                for (int i = 0; i < W; i++)
                {
                    Console.Write("-");
                }
            }
        }
    }
}

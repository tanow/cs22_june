using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p07_z12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());

            if (W < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
            }
            if (H < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
            }
            if (W > 0 && H > 0)
            {
                for (int i = 0; i < H; i++)
                {
                    for (int y = 0; y < W - i; y++)
                    {
                        Console.Write("+");
                    }
                    for (int u = 0; u < i && u < W; u++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

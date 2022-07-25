using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p07_z15
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1, S2, S;
            S1 = Console.ReadLine();
            S2 = Console.ReadLine();

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
            if (H > 0 && W > 0)
            {
                for (int i = 0; i < H; i++)
                {
                    if (i % 2 == 0)
                    {
                        S = S1;
                    }
                    else
                    {
                        S = S2;
                    }
                    for (int y = 0; y < W; y++)
                    {
                        Console.Write(S);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

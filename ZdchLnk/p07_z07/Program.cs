using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z07
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            int W, H;

            S = Console.ReadLine();
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
                for (int i = 0; i < H; i++)
                {
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

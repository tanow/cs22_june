using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p06_z25
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, width, MaxAB, MinAB, i;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            width = int.Parse(Console.ReadLine());
            i = 0;

            MaxAB = Math.Max(A, B);
            MinAB = Math.Min(A, B);

            if (width > 0)
            {
                while (MinAB <= MaxAB)
                {
                    Console.Write(MinAB);
                    i++;
                    if (MinAB + 1 <= MaxAB && i != width)
                    {
                        Console.Write("___");
                    }
                    if (i == width)
                    {
                        Console.WriteLine();
                        i = 0;
                    }
                    MinAB++;
                }
                Console.WriteLine();
            }
        }
    }
}

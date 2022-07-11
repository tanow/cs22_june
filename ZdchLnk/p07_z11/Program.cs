using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z11
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, maxAB, minAB, i;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            maxAB = Math.Max(A, B);
            minAB = Math.Min(A, B);
            i = 0;

            while (minAB <= maxAB)
            {
                if (minAB % 2 != 0)
                {
                    for (int y = 0; y < i; y++)
                    {
                        Console.Write(".");
                    }
                    Console.Write(minAB + "\n");
                    i++;
                }
                minAB++;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p07_z16
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1, S2, S;
            S1 = Console.ReadLine();
            S2 = Console.ReadLine();

            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());

            if (W < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательным");
            }
            if (H < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательным");
            }
            if (H > 0 && W > 0)
            {
                while (H > 0)
                {
                    for (int i = 0; i < W; i++)
                    {
                        if (i % 2 == 0)
                        {
                            S = S1;
                        }
                        else
                        {
                            S = S2;
                        }
                        Console.Write(S);
                    }
                    Console.WriteLine();
                    H--;
                }
            }
            
        }
    }
}

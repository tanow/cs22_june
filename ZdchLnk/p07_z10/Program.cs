using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z10
{
    class Program
    {
        static void Main(string[] args)
        {
            int H;
            string S;

            S = Console.ReadLine();
            H = int.Parse(Console.ReadLine());

            if (H < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
            }
            else
            {
                for (int i = 1; i <= H; i++)
                {
                    for (int y = i; y > 0; y--)
                    {
                        Console.Write(S);
                    }

                    Console.WriteLine();
                }
            }
            
        }
    }
}

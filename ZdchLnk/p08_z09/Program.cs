using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z09
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            int B = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());

            int maxBE, minBE;

            String[] arr = data.Split(' ');

            if (B > arr.Length - 1 || B < 0)
            {
                Console.WriteLine("Число B должно быть в интервале от [0, {0})", arr.Length);
            }
            if (E > arr.Length - 1 || E < 0)
            {
                Console.WriteLine("Число E должно быть в интервале от [0, {0})", arr.Length);
            }
            if (B >= 0 && E >= 0 && arr.Length - 1 >= B && arr.Length - 1 >= E)
            {
                maxBE = Math.Max(B, E);
                minBE = Math.Min(B, E);

                while (maxBE >= minBE)
                {
                    Console.Write(arr[minBE] + " ");
                    minBE++;
                }
            }
            
            Console.WriteLine();

        }
    }
}

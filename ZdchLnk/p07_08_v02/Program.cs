using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_08_v02
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, reshSchet;
            start = int.Parse(Console.ReadLine());
            reshSchet = 0;

            for (int i = start; i <= start + 11; i++)
            {
                Console.Write(i);
                reshSchet++;
                if (reshSchet == 3)
                {
                    Console.Write(" ");
                    for (int y = 0; y < i && y < 30; y++)
                    {
                        Console.Write("#");
                    }
                    reshSchet = 0;
                }
                Console.WriteLine();
            }
        }
    }
}

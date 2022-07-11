using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z08
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, reshSchet;
            start = int.Parse(Console.ReadLine());
            reshSchet = 0;

            for (int i = 0; i <= 11; i++)
            {
                Console.Write(start);
                
                reshSchet++;
                if (reshSchet == 3)
                {
                    Console.Write(" ");
                    for (int y = start, u = 0; y > 0 && u < 30; y--, u++)
                    {
                        Console.Write("#");
                    }
                    reshSchet = 0;
                }
                Console.WriteLine();
                start++;
            }
        }
    }
}

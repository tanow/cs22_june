using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p06_z26
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, start, end;

            X = int.Parse(Console.ReadLine());
            start = 30;
            end = 40;

            while (start <= end)
            {
                Console.Write(start);
                if (start == X)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                start++;
            }
        }
    }
}

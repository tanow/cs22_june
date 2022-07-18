using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p06_z27
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());
            
            if (X <= 0)
            {
                Console.WriteLine("Значение X должно быть положительным");
            }
            else
            {
                for (int i = 1; i <= X; i++)
                {
                    if (X % i == 0)
                    {
                        Console.Write(i);
                        if (i < X)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

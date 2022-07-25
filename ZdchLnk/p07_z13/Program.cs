using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p07_z13
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            
            if (A < B)
            {
                while (A <= B)
                {
                    if (A % 2 != 0)
                    {
                        Console.Write(A);
                        if (A + 2 <= B)
                        {
                            Console.Write(", ");
                        }
                        
                    }
                    A = A + 1;
                }
            }
            else
            {
                while (A >= B)
                {
                    if (A % 2 != 0)
                    {
                        Console.Write(A);
                        if (A - 2 >= B)
                        {
                            Console.Write(", ");
                        }
                    }
                    A = A - 1;
                }
            }
            Console.Write("\n");


        }
    }
}

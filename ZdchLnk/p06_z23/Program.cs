using System;

namespace p06_z23
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            
            if (N < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.Write("!");
                    if (i % 5 == 0)
                    {
                        Console.Write(" ");
                    }
                }
            }
            
        }
    }
}

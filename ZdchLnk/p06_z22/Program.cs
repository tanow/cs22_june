using System;

namespace p06_z22
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, ciklCifr;
            N = int.Parse(Console.ReadLine());
            ciklCifr = 0;
            
            if (N < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }
            else
            {
                for (int i = 0; i <= N; i++)
                {
                    Console.Write(i + " - ");
                    Console.Write(ciklCifr + "\n");
                    if (ciklCifr < 3)
                    {
                        ciklCifr++;
                    }
                    else
                    {
                        ciklCifr = 0;
                    }

                }
            }
            
        }
    }
}

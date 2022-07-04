using System;

namespace p06_z21
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("a\tb\tc");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}\t{1}\t{2}", A, B, C);
                if (A == 10 || B == 10 || C == 10)
                {
                    Console.Write(" Найдено");
                }
                Console.WriteLine();
                A++;
                B++;
                C++;
            }
        }
    }
}

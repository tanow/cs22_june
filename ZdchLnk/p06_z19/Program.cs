using System;

namespace p06_z19
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, i, maxAB;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            i = 0;
            maxAB = Math.Max(A, B);
            A = Math.Min(A, B);
            B = maxAB;
            while (A <= B)
            {
                Console.WriteLine(A + " " + maxAB);
                A = A + 1;
                maxAB = maxAB - 1;
                i = i + 1;
            }
            Console.WriteLine("Всего строк " + i);


        }
    }
}

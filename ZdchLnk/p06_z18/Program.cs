using System;

namespace p06_z18
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            if (B > A)
            {
                Console.WriteLine("По возрастанию");
                while (A <= B)
                {
                    Console.Write(A + " ");
                    A = A + 1;
                }
            }
            else
            {
                Console.WriteLine("По убыванию");
                while (B <= A)
                {
                    Console.Write(B + " ");
                    B = B + 1;
                }
            }
        }
    }
}

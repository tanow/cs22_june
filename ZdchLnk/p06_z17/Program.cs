using System;

namespace p06_z17
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("От B до A");
                while (B <= A)
                {
                    Console.Write(B + " ");
                    B = B + 1;
                }
            }
            else if (B > A)
            {
                Console.WriteLine("От A до B");
                while (A <= B)
                {
                    Console.Write(A + " ");
                    A = A + 1;
                }
            }
            else
            {
                Console.WriteLine("Границы равны");
                Console.Write(A);
            }

        }
    }
}

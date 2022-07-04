using System;

namespace p06_z15
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
                Console.WriteLine("Значение A должно быть не больше значения B");
            }
            else
            {
                while (A <= B)
                {
                    Console.Write(A + ";");
                    A = A + 1;
                }
            }

        }
    }
}

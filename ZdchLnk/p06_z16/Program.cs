using System;

namespace p06_z16
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
                Console.Write("{");
                while (B >= A)
                {
                    Console.Write(" " + B);
                    B = B - 1;
                }
                Console.Write(" }");
            }
        }
    }
}

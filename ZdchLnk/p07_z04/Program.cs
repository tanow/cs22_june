using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z04
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            if (A < 0)
            {
                Console.WriteLine("Количество символов в первой строке должно быть неотрицательным");
            }
            if ((A + B) < 0)
            {
                Console.WriteLine("Количество символов во второй строке должно быть неотрицательным");
            }
            if (A >= 0 && (A + B) >= 0)
            {
                for (int i = 0; i < A; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                for (int i = 0; i < (A + B); i++)
                {
                    Console.Write("*");
                }
            }
        }

    }
}

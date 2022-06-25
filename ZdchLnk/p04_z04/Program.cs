using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z04
{
    class Program
    {
        static void Main(string[] args)
        {
            double M, P;
            M = double.Parse(Console.ReadLine());
            P = double.Parse(Console.ReadLine());
            if (P == 0)
            {
                Console.WriteLine("Значение P не должно быть равно нулю");
            }
            else if (M % P == 0)
            {
                Console.WriteLine(M / P);
            }
            else
            {
                Console.WriteLine("{0:F0} не делится нацело на {1:F0}", M, P);
            }
        }
    }
}

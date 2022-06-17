using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z03
{
    class Program
    {
        static void Main(string[] args)
        {
            double M, P, ost, chast;
            M = double.Parse(Console.ReadLine());
            P = double.Parse(Console.ReadLine());
            ost = M % P;
            chast = M / P;
            if (ost == 0)
            {
                Console.WriteLine(chast);
            }
            else
            {
                Console.WriteLine("{0:F0} не делится нацело на {1:F0}", M, P);
            }
        }
    }
}

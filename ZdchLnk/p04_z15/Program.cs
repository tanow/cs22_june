using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z15
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, Z;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            Z = int.Parse(Console.ReadLine());
            if (X > 0)
            {
                X = X * X;
            }
            if (Y > 0)
            {
                Y = Y * Y;
            }
            if (Z > 0)
            {
                Z = Z * Z;
            }
            Console.WriteLine("{0:F0};{1:F0};{2:F0}", X, Y, Z);
        }
    }
}

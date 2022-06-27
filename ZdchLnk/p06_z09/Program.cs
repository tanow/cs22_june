using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z09
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, i, y, X_y, shag;
            X = int.Parse(Console.ReadLine());
            i = 0;
            y = 0;
            X_y = X;
            shag = 0;
            while (i < 11)
            {
                Console.Write(X + " ");
                X = X + 3;
                i = i + 1;
            }
            Console.WriteLine();
            while (y < 11)
            {
                Console.Write(X_y - 40 + shag + " ");
                y = y + 1;
                shag = shag + 4;
            }
        }
    }
}

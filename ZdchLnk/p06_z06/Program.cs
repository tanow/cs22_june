using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z06
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, i;
            i = 0;
            X = int.Parse(Console.ReadLine());

            while (i < 11)
            {
                Console.Write(X + " ");
                i = i + 1;
                X = X + 3;
            }

        }
    }
}

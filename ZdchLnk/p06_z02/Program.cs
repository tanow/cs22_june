using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, i;
            A = int.Parse(Console.ReadLine());
            i = 0;

            while (i < 10)
            {
                Console.WriteLine(A);
                Console.WriteLine("---");
                i = i + 1;
                A = A + 1;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z03
{
    class Program
    {
        static void Main(string[] args)
        {
            string X;
            int i;

            X = Console.ReadLine();
            i = 1;
            Console.Write("\"");
            while (i < 8)
            {
                Console.Write(X);
                i = i + 1;
            }
            Console.Write("\"");
        }
    }
}

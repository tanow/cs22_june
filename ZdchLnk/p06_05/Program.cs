using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int V, i, result;
            
            i = 1;
            V = int.Parse(Console.ReadLine());

            Console.WriteLine("Таблица умножения на " + V);
            while (i < 10)
            {
                result = i * V;
                Console.WriteLine("{0} x {1} = {2}", i, V, result);
                i = i + 1;
            }

        }
    }
}

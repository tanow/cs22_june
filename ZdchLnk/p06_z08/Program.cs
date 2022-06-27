using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z08
{
    class Program
    {
        static void Main(string[] args)
        {
            int wildth, i;
            i = 1;
            wildth = int.Parse(Console.ReadLine());
            if (wildth < 0)
            {
                Console.WriteLine("Вводимое число должно быть неотрицательно");
            }
            while (i <= wildth && i <= 20)
            {
                Console.Write("*");
                i = i + 1;
            }
        }
    }
}

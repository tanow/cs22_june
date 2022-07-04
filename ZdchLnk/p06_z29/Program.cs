using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z29
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y, i;
            Y = int.Parse(Console.ReadLine());
            i = 0;
            if (Y < 0 || Y > 15)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
            }
            else
            {
                while (i < Y)
                {
                    Console.Write("#");
                    i++;
                }
                while ((15 - i) > 0)
                {
                    Console.Write(".");
                    i++;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z06
{
    class Program
    {
        static void Main(string[] args)
        {
            int W, i;
            W = int.Parse(Console.ReadLine());
            i = 0x0030;
            if (W < 0 || W > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0, 20]");
            }
            else
            {
                while (i < 0x003A)
                {
                    Console.WriteLine(new string((char)i, W));
                    i++;
                }
                
            }
        }
    }
}

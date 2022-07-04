using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int W;
            W = int.Parse(Console.ReadLine());

            
           
            if (W < 0 || W > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0, 20]");
            }
            else
            {
                for (int i = 0x0061; i < 0x0069; i++)
                Console.WriteLine(new string((char) i, W));
            }
        }
    }
}

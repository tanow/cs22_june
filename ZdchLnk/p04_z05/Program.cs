using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z05
{
    class Program
    {
        static void Main(string[] args)
        {
            double small, large, small_f, large_f;
            small = double.Parse(Console.ReadLine());
            large = double.Parse(Console.ReadLine());
            if (small < 0 || small > 5)
            {
                Console.WriteLine("Фактическое количество жидкости в маленькой емкости должно быть от 0 до 5 литров включительно");
            }
            if (large < 0 || large > 8)
            {
                Console.WriteLine("Фактическое количество жидкости в большой емкости должно быть от 0 до 8 литров включительно");
            }
            if (small >= 0 && small < 6 && large >= 0 && large < 9)
            {
                large_f = Math.Min(8, small + large);
                small_f = small - (large_f - large);
                Console.WriteLine("Было: в маленькой {0:F0} из 5, в большой {1:F0} из 8\nСтало: в маленькой {2} из 5, в большой {3} из 8", small, large, small_f, large_f);
            }
            
        }
    }
}

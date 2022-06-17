using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z02
{
    class Program
    {
        static void Main(string[] args)
        {
            double K, root, square;
            K = double.Parse(Console.ReadLine());
            if (K > 0)
            {
                root = Math.Sqrt(K);
                Console.WriteLine("Корень из {0:F4} равен {1:F4}", K, root);
            }
            else
            {
                square = Math.Pow(K, 2);
                Console.WriteLine("Квадрат из {0:F4} равен {1:F4}", K, square);
            }
        }
    }
}

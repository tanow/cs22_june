using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z01
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, Q, max, min, diff;
            P = double.Parse(Console.ReadLine());
            Q = double.Parse(Console.ReadLine());
            max = Math.Max(P, Q);
            min = Math.Min(P, Q);
            diff = Math.Abs(max - min);
            Console.WriteLine("Максимальное {0:F0}, минимальное {1:F0}. Разница {2:F0}", max, min, diff);
        }
    }
}

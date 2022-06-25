using System;

namespace p02_z07
{
    class Program
    {
        static void Main(string[] args)
        {
            double knots, KmH;
            knots = double.Parse(Console.ReadLine());
            KmH = knots * 2 * 0.9;
            Console.WriteLine("{0:F2} узлов это {1:F2} км/ч", knots, KmH);
        }
    }
}

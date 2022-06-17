using System;

namespace p03_z10
{
    class Program
    {
        static void Main(string[] args)
        {
            double xDeg, xRad, result;
            xDeg = double.Parse(Console.ReadLine());
            xRad = xDeg * Math.PI / 180;
            result = Math.Sin(xRad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}

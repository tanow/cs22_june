using System;

namespace p03_z12
{
    class Program
    {
        static void Main(string[] args)
        {
            double yDeg, yRad, result;
            yDeg = double.Parse(Console.ReadLine());
            yRad = yDeg * Math.PI / 180;
            result = 5 * Math.Cos(yRad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}

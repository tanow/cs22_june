using System;

namespace p03_z14
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDeg, aRad, bDeg, bRad, result;
            aDeg = double.Parse(Console.ReadLine());
            bDeg = double.Parse(Console.ReadLine());
            aRad = aDeg * Math.PI / 180;
            bRad = bDeg * Math.PI / 180;
            result = 3 * Math.Sin(2 * aRad) * Math.Cos(3 * bRad);
            Console.WriteLine("{0:F4}", result);

        }
    }
}

using System;

namespace p03_z13
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDeg, bDeg, aRad, bRad, result;
            aDeg = double.Parse(Console.ReadLine());
            bDeg = double.Parse(Console.ReadLine());
            aRad = aDeg * Math.PI / 180;
            bRad = bDeg * Math.PI / 180;
            result = Math.Sin(aRad) * Math.Cos(bRad) + Math.Cos(aRad) * Math.Sin(bRad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}

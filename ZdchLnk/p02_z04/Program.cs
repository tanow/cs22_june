using System;

namespace p02_z04
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDeg, aRad;
            aDeg = double.Parse(Console.ReadLine());
            aRad = aDeg * Math.PI / 180;
            Console.WriteLine("{0:F4}", aRad);
        }
    }
}

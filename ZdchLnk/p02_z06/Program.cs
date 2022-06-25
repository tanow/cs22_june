using System;

namespace p02_z06
{
    class Program
    {
        static void Main(string[] args)
        {
            double aRad, aDeg;
            aRad = double.Parse(Console.ReadLine());
            aDeg = aRad * 180 / Math.PI;
            Console.WriteLine("{0:F4} радиан это {1:F4} градусов", aRad, aDeg);
        }
    }
}

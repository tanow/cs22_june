using System;

namespace p03_z04
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, circumference;
            radius = double.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Радиус должен быть положительным");
            }
            else
            {
                circumference = 2 * Math.PI * radius;
                Console.WriteLine("{0:F4}", circumference);
            }
        }
    }
}

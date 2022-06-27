using System;

namespace p03_z05
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, volume;
            radius = double.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Значение radius должно быть положительным");
            }
            else
            {
                volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
                Console.WriteLine("{0:F4}", volume);
            }
        }
    }
}

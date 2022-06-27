using System;

namespace p03_z02
{
    class Program
    {
        static void Main(string[] args)
        {
            double edge, height, area;
            edge = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            if (edge <= 0)
            {
                Console.WriteLine("Длина основания треугольника должна быть положительна");
            }
            if (height <= 0)
            {
                Console.WriteLine("Высота треугольника должна быть положительна");
            }
            if (edge > 0 && height > 0)
            {
                area = edge * height * 0.5;
                Console.WriteLine("{0:F2}", area);
            }
        }
    }
}

using System;

namespace p03_z09
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureC, tempatureF;
            temperatureC = double.Parse(Console.ReadLine());
            tempatureF = temperatureC * 1.8 + 32;
            Console.WriteLine("{0:F4}", tempatureF);
        }
    }
}

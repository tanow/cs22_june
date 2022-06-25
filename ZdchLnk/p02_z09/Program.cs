using System;

namespace p02_z09
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureC, temperatureF;
            temperatureC = double.Parse(Console.ReadLine());
            temperatureF = temperatureC * 1.8 + 32;
            Console.WriteLine("{0:F4}", temperatureF);
        }
    }
}

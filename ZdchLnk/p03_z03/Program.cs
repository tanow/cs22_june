using System;

namespace p03_z03
{
    class Program
    {
        static void Main(string[] args)
        {
            double edge, volume;
            edge = double.Parse(Console.ReadLine());
            if (edge <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
            }
            else
            {
                volume = Math.Pow(edge, 3);
                Console.WriteLine("{0:F0}", volume);
            }
        }
    }
}

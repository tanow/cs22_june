using System;

namespace p02_z08
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocityInKmH, velocityInMS;
            velocityInKmH = double.Parse(Console.ReadLine());
            velocityInMS = velocityInKmH * 1000 / 3600;
            Console.WriteLine("{0:F2} км/ч это {1:F2} м/с", velocityInKmH, velocityInMS);
        }
    }
}

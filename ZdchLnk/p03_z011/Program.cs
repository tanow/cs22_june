using System;

namespace p03_z011
{
    class Program
    {
        static void Main(string[] args)
        {
            double aX, aY, bX, bY, aMod, bMod, productAB, angeleABRad, angeleABDeg;
            aX = double.Parse(Console.ReadLine());
            aY = double.Parse(Console.ReadLine());
            bX = double.Parse(Console.ReadLine());
            bY = double.Parse(Console.ReadLine());

            aMod = Math.Sqrt(Math.Pow(aX, 2) + Math.Pow(aY, 2));
            bMod = Math.Sqrt(Math.Pow(bX, 2) + Math.Pow(bY, 2));

            productAB = aX * bX + aY * bY;

            angeleABRad = Math.Acos(productAB/aMod/bMod);
            angeleABDeg = angeleABRad * 180 / Math.PI;

            Console.WriteLine("Модуль верктора a = {0:F4}", aMod);
            Console.WriteLine("Модуль вектора b = {0:F4}", bMod);
            Console.WriteLine("Скалярное произведение векторов равно {0:F4}", productAB);
            Console.WriteLine("Угол между векторами составляет {0:F4} градусов", angeleABDeg);
        }
    }
}

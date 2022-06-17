using System;

namespace p03_z11
{
    class Program
    {
        static void Main(string[] args)
        {
            double cathetus, angeleDeg, angeleRad, cosAngeleRad, hypotenuse;
            cathetus = double.Parse(Console.ReadLine());
            angeleDeg = double.Parse(Console.ReadLine());
            angeleRad = angeleDeg * Math.PI / 180;
            cosAngeleRad = Math.Cos(angeleRad);
            hypotenuse = cathetus / cosAngeleRad;
            Console.WriteLine("Значение угла в радианах {0:F4}\nКосинус этого угла {1:F4}\nДлина гипотенузы {2:F4}",
                angeleRad, cosAngeleRad, hypotenuse);
        }
    }
}

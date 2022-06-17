using System;

namespace p03_z15
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xa, Ya, distance, angeleDeg, angeleRad, dX, dY, Xb, Yb;
            Xa = double.Parse(Console.ReadLine());
            Ya = double.Parse(Console.ReadLine());
            distance = double.Parse(Console.ReadLine());
            angeleDeg = double.Parse(Console.ReadLine());
            angeleRad = angeleDeg * Math.PI / 180;
            dX = distance * Math.Cos(angeleRad);
            dY = distance * Math.Sin(angeleRad);
            Xb = Xa + dX;
            Yb = Ya + dY;
            Console.WriteLine("Приращение координат: \u0394x = {0:F4}; \u0394 = {1:F4}\n" +
                "Координаты второй точки ({2:F4};{3:F4})", dX, dY, Xb, Yb);
            
        }
    }
}

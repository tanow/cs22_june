using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_z06
{
    class Program
    {
        static void Main(string[] args)
        {
            double tC, state, Q, m, tK, c, r, limbda, Q_cristal, Q_licvid, Q_gaz;
            c = 4.2 * 1000;
            r = 2.26 * Math.Pow(10, 6);
            limbda = 3.3 * Math.Pow(10, 5);
            m = 17;
            tC = double.Parse(Console.ReadLine());
            tK = tC + 273.15;
            if (tC == 0 || tC == 100)
            {
                Console.WriteLine("Вещество в переходном состоянии");
            }
            if (tC >= -273 && tC <= 0)
            {
                Q_cristal = m * tK * c;
                Console.WriteLine("Агрегатное состояние: кристал\nВнутренная энергия: {0:F0} Дж", Q_cristal);   
            }
            if (tC >= 0 && tC <= 100)
            {
                Q_licvid = m * (tK * c + r);
                Console.WriteLine("Агрегатное состояниеЖ жидкость\nВнутренная энергия: {0:F0} Дж", Q_licvid);
            }
            if (tC >= 100)
            {
                Q_gaz = m * (tK * c + r + limbda);
                Console.WriteLine("Агрегатное состояние: газ\nВнутренная энергия: {0:F0} Дж", Q_gaz);
            }
            if (tC < -273)
            {
                Console.WriteLine("Некорректная температура");
            }
            
        }
    }
}

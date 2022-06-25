using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z06
{
    class Program
    {
        static void Main(string[] args)
        {
            double roadKm, roadFeed, lenghtFeet, lenghtKm;
            roadKm = double.Parse(Console.ReadLine());
            lenghtFeet = double.Parse(Console.ReadLine());
            lenghtKm = lenghtFeet * 0.305 / 1000;
            roadFeed = roadKm * 1000 / 0.305;
            if (roadKm > 0 && lenghtFeet > 0)
            {
                Console.WriteLine("Расстояние {0:F0} км это {1:F0} футов");
            }
        }
    }
}

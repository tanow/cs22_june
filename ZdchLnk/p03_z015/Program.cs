using System;

namespace p03_z015
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthSeconds, lengthOstSeconds, lengthOstMinutes, lengthOstHours;
            lengthSeconds = double.Parse(Console.ReadLine());

            lengthOstSeconds = (lengthSeconds % 60) % 60;
            lengthOstMinutes = ((lengthSeconds % 3600 - (lengthSeconds % 60)) % 60) / 60;
            lengthOstHours = lengthSeconds / 3600;

            Console.WriteLine("{0:F0} часов {1:F0} минут {2:F0} секунд", lengthOstHours, lengthOstMinutes, lengthOstSeconds);
        }
    }
}

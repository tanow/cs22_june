using System;

namespace p03_z014
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInitial, aRemainder;
            aInitial = double.Parse(Console.ReadLine());
            aRemainder = aInitial % 360;

            Console.WriteLine("{0:F0}", aRemainder);

        }
    }
}

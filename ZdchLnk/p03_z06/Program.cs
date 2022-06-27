using System;

namespace p03_z06
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, result;
            
            x = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Значение X должно быть неотрицательным");
            }
            else
            {
                result = Math.Pow(x, 0.5);
                Console.WriteLine("{0:F4}", result);
            }
        }
    }
}

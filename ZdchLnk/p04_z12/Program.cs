using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z12
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("Первое");
            }
            else if (B > A)
            {
                Console.WriteLine("Второе");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_z01
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 100;
            int end = 500;
            
            int sum = start;
            Console.Write(start + " ");

            for (int i = start + 1; i <= end; i++)
            {
                sum = sum + i;
                Console.Write(sum);
                if (i + 1 <= end)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine("\nОтвет: {0}\n", sum);
           
        }
    }
}

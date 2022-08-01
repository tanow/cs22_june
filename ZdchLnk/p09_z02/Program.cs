using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_z02
{
    class Program
    {
        static void Main(string[] args)
        {
            String left = Console.ReadLine();

            String right = Console.ReadLine();

            String[] arrLeft = left.Split(' ');

            String[] arrRight = right.Split(' ');

            if (arrLeft.Length != arrRight.Length)
            {
                Console.WriteLine("Размеры массивов должны быть одинаковы");
                return;
            }

            int[] num = new int[arrRight.Length];

            for (int i = 0; i < arrRight.Length; i++)
            {
                num[i] = Int32.Parse(arrRight[i]) * Int32.Parse(arrLeft[i]);
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
                if (i + 1 < num.Length)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z17
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            String[] arr = data.Split(' ');

            String[] arrSecond = data.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                arrSecond[i] = arr[i];
            }

            for (int i = 0; i + 1 < arr.Length; i++)
            {
                arr[i + 1] = arrSecond[i];
            }

            arr[0] = arrSecond[(arr.Length - 1)];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i + 1 < arr.Length)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z10
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Нет данных");
                return;
            }

            String[] arr = data.Split(' ');

            for (int i=0; i < arr.Length; i++)
            {
                if (i-1 >= 0)
                {
                    Console.Write(arr[i - 1]);
                }
                else if (i-1 < 0)
                {
                    Console.Write("BEGIN");
                }
                Console.Write(" " + arr[i] + " ");
                if (i + 1 < arr.Length)
                {
                    Console.Write(arr[i + 1]);
                }
                else if (i + 1 == arr.Length)
                {
                    Console.Write("END");
                }
                Console.WriteLine();
            }
        }
    }
}

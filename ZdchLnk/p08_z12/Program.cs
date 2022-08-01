using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z12
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            String[] arr = data.Split(',');

            int index = int.Parse(Console.ReadLine());

            String value = Console.ReadLine();

            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Число A должно быть в интервале [0, {0})", arr.Length);
                return;
            }

            arr[index] = value;

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

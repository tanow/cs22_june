using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z16
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходная строка пуста");
            }

            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());

            String[] arr = data.Split(' ');

            if (P < 0 || P >= arr.Length)
            {
                Console.WriteLine("Число P должно быть в интервале [0, {0})", arr.Length);
            }
            if (Q < 0 || Q >= arr.Length)
            {
                Console.WriteLine("Число Q должно быть в интервале [0, {0})", arr.Length);
            }
            if (P >= 0 && Q >= 0 && P < arr.Length && Q < arr.Length)
            {
                Console.WriteLine("Меняю {0} на {1}", arr[P], arr[Q]);

                String var;

                var = arr[P];
                arr[P] = arr[Q];
                arr[Q] = var;

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                    if (i + 1 < arr.Length)
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

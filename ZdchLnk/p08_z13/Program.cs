using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z13
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }

            String[] arr = data.Split(' ');

            String append = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());

            if (arr.Length < a + 1)
            {
                for (int i = arr.Length; i <= a; i++)
                {
                    data = data + " " + "empty";
                }

                String[] arrTwo = data.Split(' ');

                arrTwo[a] = append;

                for (int i = 0; i < arrTwo.Length; i++)
                {
                    Console.Write(arrTwo[i]);
                    if (i + 1 < arrTwo.Length)
                    {
                        Console.Write(" ");
                    }
                }
            }
            else if (arr.Length >= a+ 1)
            {
                arr[a] = append;

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

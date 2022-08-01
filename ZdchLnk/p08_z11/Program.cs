using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z11
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

            Console.WriteLine("Индекс последнего элемента " + (arr.Length - 1));
            Console.WriteLine("Значение последнего элемента " + arr[(arr.Length - 1)]);
            Console.WriteLine("Вместо " + arr[0] + " пишем " + arr[(arr.Length - 1)]);
            Console.WriteLine("Элементы массива:");

            Console.Write(arr[(arr.Length - 1)]);

            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(" ");
                Console.Write(arr[i]);
            }

            Console.WriteLine();
        }
    }
}

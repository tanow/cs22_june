using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_z05
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

            String[] arr = data.Split(';');

            int middle;

            Console.Write("Длина массива: {0}, ", arr.Length);

            middle = (arr.Length - 1) / 2;

            Console.Write("индекс: {0}, ", middle);
            Console.Write("элемент: {0}\n", arr[middle]);
        }
    }
}

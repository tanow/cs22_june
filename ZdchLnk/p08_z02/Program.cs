using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_z02
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

            String[] arr = data.Split(',');

            if (arr.Length - 1 >= 0)
            {
                Console.WriteLine("Значение элемента в индексе 0 это {0}", arr[0]);
            }
            if (arr.Length - 1 >= 2)
            {
                Console.WriteLine("Значение элемента в индексе 2 это {0}", arr[2]);
            }
            else
            {
                Console.WriteLine("Нет элемента на индексе 2");
            }
            if (arr.Length - 1 >= 3)
            {
                Console.WriteLine("Значение элемента в индексе 3 это {0}", arr[3]);
            }
            else
            {
                Console.WriteLine("Нет элемента на индексе 3");
            }
            if (arr.Length - 1 >= 5)
            {
                Console.WriteLine("Значение элемента в индексе 5 это {0}", arr[5]);
            }
            else
            {
                Console.WriteLine("Нет элемента на индексе 5");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_z04
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

            String[] arr = data.Split('#');

            if (arr.Length < 3)
            {
                Console.WriteLine("Массив слишком маленький");
            }
            else
            {
                Console.WriteLine("Индекс третьего элемента с конца {0}", arr.Length - 3);
                Console.WriteLine("Значение этого элемента {0}", arr[arr.Length - 3]);
            }

        }
    }
}

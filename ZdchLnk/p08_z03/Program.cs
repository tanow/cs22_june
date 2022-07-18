using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_z03
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

            int T = int.Parse(Console.ReadLine());

            if (T <= arr.Length - 1 && T > 0)
            {
                Console.WriteLine("Элемент на индексе {0} содержит значение {1}", T, arr[T]);
            }
            else
            {
                Console.WriteLine("Число T должно быть в инервале [0, {0})", arr.Length);
                return;
            }
            if (T - 1 >= 0)
            {
                Console.WriteLine("Значение предыдущего элемента {0}", arr[T - 1]);
            }
            else
            {
                Console.WriteLine("Предыдущий элемент не существует");
            }
            if (T < arr.Length - 1)
            {
                Console.WriteLine("Значение следующего элемента {0}", arr[T + 1]);
            }
            else
            {
                Console.WriteLine("Следующий элемент не существует");
            }
        }
    }
}

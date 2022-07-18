using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_z01
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

            int A = int.Parse(Console.ReadLine());

            if (A < 0 || arr.Length - 1 < A)
            {
                Console.WriteLine("Число A должно быть в интервале [0, {0}]", arr.Length - 1);
                return;
            }
            Console.WriteLine("В массиве длиной {0}", arr.Length);
            Console.WriteLine("на индексе " + A);
            Console.WriteLine("находится элемент со значением " + arr[A]);

            

        }
    }
}

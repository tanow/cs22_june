using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_z01
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

            String[] arr = data.Split(' ');
            int[] num = new int[arr.Length];

            int m = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                num[i] = Int32.Parse(arr[i]) * m;
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}

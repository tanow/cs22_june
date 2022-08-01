using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_z02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numConst = { 0, 1, 3, 4 };

            int sum;

            String data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходные данные пусты");
                return;
            }

            String[] arr = data.Split(' ');

            int[] num = new int[arr.Length];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Int32.Parse(arr[i]);
            }

            Console.WriteLine("Значение элемента на индексе {0} это {1}", numConst[0], num[numConst[0]]);
            sum = num[(numConst[0])];
            Console.WriteLine("Промежуточный итог: {0}", sum);

            for (int i = 1; i < numConst.Length; i++)
            {
                if (numConst[i] < num.Length)
                {
                    Console.WriteLine("Значение элемента на индексе {0} это {1}", numConst[i], num[numConst[i]]);
                    sum = sum + num[numConst[i]];
                    Console.WriteLine("Промежуточный итог: {0}", sum);
                }
                else if (numConst[i] >= num.Length)
                {
                    Console.WriteLine("Нет элемента на идексе {0}", numConst[i]);
                }
                
            }

            Console.WriteLine("Финальный итог: {0}", sum);



        }
    }
}

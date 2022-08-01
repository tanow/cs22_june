using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_z05
{
    class Program
    {
        static void Main(string[] args)
        {
            String fragments = Console.ReadLine();

            String indexes = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(fragments))
            {
                Console.WriteLine("Отсутствуют данные о фрагментах");
                return;
            }
            if (String.IsNullOrWhiteSpace(indexes))
            {
                Console.WriteLine("Отсутствуют данные об индексах");
                return;
            }

            String[] arrFragments = fragments.Split(' ');

            String[] arrIndexes = indexes.Split(' ');

            int[] numIndexes = new int[arrIndexes.Length];

            for (int i = 0; i < arrIndexes.Length; i++)
            {
                numIndexes[i] = Int32.Parse(arrIndexes[i]);
            }
            
            for (int i = 0; i < numIndexes.Length; i++)
            {
                if (numIndexes[i] < arrFragments.Length)
                {
                    Console.WriteLine("Значение элемента на индексе {0} это {1}", numIndexes[i], arrFragments[numIndexes[i]]);
                }
                else if (numIndexes[i] >= arrFragments.Length)
                {
                    Console.WriteLine("Фрагмент на индексе {0} отсутствует", numIndexes[i]);
                }
            }
        }
    }
}

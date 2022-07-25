using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z07
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            String[] arr = data.Split(',');

            Console.WriteLine(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Глава {0} {1}", i+1, arr[i]);
            }
        }
    }
}

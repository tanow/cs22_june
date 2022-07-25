using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p08_z08
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            String[] arr = data.Split(',');

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

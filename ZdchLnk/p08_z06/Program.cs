using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_z06
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            String[] arr = data.Split(' ');

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " " + i + "\n");
                }
                
            }
            
        }
    }
}

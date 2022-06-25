using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string X, stroka;
            int Y;
            stroka = "abcdefgh";
            X = Console.ReadLine();
            if (X != "")
            {
                Y = stroka.IndexOf(X);
                if (Y >= 0)
                {
                    Console.WriteLine(stroka.Substring(0, Y + 1));
                }
                else
                {
                    Console.WriteLine(stroka);
                }
            }
            else
            {
                Console.WriteLine("");
            }
            
            
            
        }
    }
}

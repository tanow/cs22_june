using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_z02
{
    class Program
    {
        static void Main(string[] args)
        {
            int W;
            string stroka_plus, stroka_dot;
            W = int.Parse(Console.ReadLine());
            stroka_plus = "";
            stroka_dot = "";
            if (W < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
            }
            else
            {
                if (W == 0)
                {
                    Console.WriteLine("");
                }
                else if (W == 1)
                {
                    Console.Write("+\n|\n+");
                }
                else if (W == 2)
                {
                    Console.Write("++\n||\n++");
                }
                else
                {
                    for (int i = 2; i < W; i++)
                    {
                        stroka_plus = stroka_plus + "-";
                        stroka_dot = stroka_dot + ".";
                    }
                    stroka_plus = "+" + stroka_plus + "+";
                    stroka_dot = "|" + stroka_dot + "|";
                    Console.WriteLine(stroka_plus);
                    Console.WriteLine(stroka_dot);
                    Console.WriteLine(stroka_plus);
                }
            }
        }
    }
}

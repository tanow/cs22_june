using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_z16
{
    class Program
    {
        static void Main(string[] args)
        {
            string X, find;
            X = Console.ReadLine();
            find = " Найдено";
            if (X == "a")
            {
                X = "a" + find;
                Console.WriteLine("{0}\nb\nc\nd\ne\nf\ng\nh", X);
            }
            else if (X == "b")
            {
                X = "b" + find;
                Console.WriteLine("a\n{0}\nc\nd\ne\nf\ng\nh", X);
            }
            else if (X == "c")
            {
                X = "c" + find;
                Console.WriteLine("a\nb\n{0}\nd\ne\nf\ng\nh", X);
            }
            else if (X == "d")
            {
                X = "d" + find;
                Console.WriteLine("a\nb\nc\n{0}\ne\nf\ng\nh", X);
            }
            else if (X == "e")
            {
                X = "e" + find;
                Console.WriteLine("a\nb\nc\nd\n{0}\nf\ng\nh", X);
            }
            else if (X == "f")
            {
                X = "f" + find;
                Console.WriteLine("a\nb\nc\nd\ne\n{0}\ng\nh", X);
            }
            else if (X == "g")
            {
                X = "g" + find;
                Console.WriteLine("a\nb\nc\nd\ne\nf\n{0}\nh", X);
            }
            else if (X == "h")
            {
                X = "h" + find;
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng\n{0}", X);
            }
            else
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh");
            }
        }
    }
}

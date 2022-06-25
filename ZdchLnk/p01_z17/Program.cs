using System;

namespace p01_z17
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c, d;
            c = "успех";
            a = "тоже провал";
            b = "провал";

            d = c; // 4
            b = d; // 3
            d = b; // 2
            c = b; // 1
            a = b; // 5

            Console.WriteLine(a);
        }
    }
}

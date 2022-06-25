using System;

namespace p01_z18
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c, d;
            c = "success";
            a = "also a failure";
            b = "fail";
            
            b = c; // 2
            d = b; // 1
            b = d; // 3
            d = c; // 4
            a = d; // 5
            a = b; // 6

            Console.WriteLine(a);
        }
    }
}

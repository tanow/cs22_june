using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_z16
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c;
            c = "успех";
            b = "тоже провал";
            a = "провал";
            b = c;
            c = b;
            a = b;
            b = a;
            Console.WriteLine(a);
        }
    }
}

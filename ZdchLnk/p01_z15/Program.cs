using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_z15
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c;
            c = "успех";
            b = "провал";
            b = c;
            c = b;
            a = b;
            Console.WriteLine(a);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Предисловие");
            int i;
            i = 1;

            while (i < 8)
            {
                Console.WriteLine("Глава " + i);
                i = i + 1;
            }

            Console.WriteLine("Послесловие");


        }
    }
}

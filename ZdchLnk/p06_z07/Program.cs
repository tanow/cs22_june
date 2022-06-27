using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z07
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, i, rezult;
            i = 0;
            rezult = i;
            limit = int.Parse(Console.ReadLine());

            while (rezult < limit)
            {
                Console.Write(rezult + " ");
                i = i + 1;
                rezult = rezult + i;
            }
        }
    }
}

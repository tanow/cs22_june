using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_z04
{
    class Program
    {
        static void Main(string[] args)
        {
            int funt, gramm;
            funt = 1;
            
            Console.WriteLine("фунт    грамм");
            while (funt < 10)
            {
                gramm = funt * 453;
                Console.WriteLine(funt + "       " + gramm);
                funt = funt + 1;
            }
            while (funt < 21)
            {
                gramm = funt * 453;
                Console.WriteLine(funt + "      " + gramm);
                funt = funt + 1;
            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_z11
{
    class Program
    {
        static void Main(string[] args)
        {
            String x, y;
            x = Console.ReadLine();
            y = Console.ReadLine();
            Console.WriteLine("INSERT INTO points(x, y) VALUES('{0}', '{1}');", x, y);
        }
    }
}

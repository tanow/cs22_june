using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p07_z14
{
    class Program
    {
        static void Main(string[] args)
        {
            int P, Q, minPQ, maxPQ;
            P = int.Parse(Console.ReadLine());
            Q = int.Parse(Console.ReadLine());

            minPQ = Math.Min(P, Q);
            maxPQ = Math.Max(P, Q);

            Q = minPQ + (maxPQ - minPQ) / 2;

            while (minPQ <= maxPQ)
            {
                P = minPQ;
                Console.Write(P);
                minPQ++;
                if (P < Q)
                {
                    Console.Write("<");
                }
                else if (P >= Q && minPQ <= maxPQ)
                {
                    Console.Write(">");
                }
            }
            Console.WriteLine();
        }
    }
}

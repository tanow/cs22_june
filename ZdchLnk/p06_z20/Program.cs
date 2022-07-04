using System;

namespace p06_z20
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            X = int.Parse(Console.ReadLine());
            
            for (int n = 10; n <=20; n++)
            {
                Console.Write(n);
                if (n == X)
                {
                    Console.WriteLine(" найдено");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            
        }
    }
}

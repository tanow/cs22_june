using System;

namespace p06_z028
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, iA, iB;
            string stroka;
            
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            
            stroka = "";
            iA = 0;
            iB = 0;

            if (A < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательно");
            }
            if (B < 0)
            {
                Console.WriteLine("Значение B должно быть неотрицательно");
            }
            if (A >= 0 && B >= 0)
            {
                while (iA <= A || iB <= B)
                {
                    if (iA <= A)
                    {
                        stroka = "" + iA;
                    }
                    else
                    {
                        stroka = " ";
                    }
                    if (iB <= B)
                    {
                        stroka = stroka + " " + iB;
                    }
                    Console.WriteLine(stroka);
                    iA++;
                    iB++;
                    stroka = "";
                }
            }
        }
    }
}

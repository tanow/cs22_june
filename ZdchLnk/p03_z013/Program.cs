using System;

namespace p03_z013
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalM, totalCm, partCm, izdeliySht, ostCm;
            totalM = double.Parse(Console.ReadLine());
            partCm = double.Parse(Console.ReadLine());

            totalCm = totalM * 100;

            ostCm = totalCm % partCm;

            izdeliySht = totalCm / partCm - ostCm / partCm;

            ;

            if (totalM <= 0)
            {
                Console.WriteLine("Длина рулона должна быть положительна");
            }
            if (partCm <= 0)
            {
                Console.WriteLine("Расход материала должен быть положительным");
            }
            if (totalM > 0 && partCm > 0)
            {
                Console.WriteLine("Длина рулона в сантиметрах равна {0:F0}", totalCm);
                if (izdeliySht >= 1)
                {
                    Console.WriteLine("Из этого материала получится {0:F0} изделий и останется {1:F0} см", izdeliySht, ostCm);
                }
                else
                {
                    Console.WriteLine("Материала не хватит даже на одно изделие");
                }
            }
        }
    }
}

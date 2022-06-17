using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_z02
{
    class Program
    {
        static void Main(string[] args)
        {
            String clientName;
            String companyName;

            clientName = "Иван Иванович";
            companyName = "ООО Рога и копыта";

            Console.WriteLine("Задача 4131\n");
            Console.Write("Уважаемый ");
            Console.Write(clientName);
            Console.WriteLine(". Поздравляем с Днем рождения.\nПусть каждый день будет наполнен счастьем!\nВаша " + companyName + ".\n");



        }
    }
}

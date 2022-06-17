using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_z08
{
    class Program
    {
        static void Main(string[] args)
        {
            String companyName, productName, productCost, messagePart;
            Console.WriteLine("Задача 1910\nВведите название компании\n");
            companyName = Console.ReadLine();
            Console.WriteLine("Введите наименование товара");
            productName = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            productCost = Console.ReadLine();
            messagePart = "Распродажа в " + companyName + "!";
            Console.WriteLine(messagePart);
            messagePart = "Наши " + productName + " по супер цене. Всего " + productCost + "!";
            Console.WriteLine(messagePart + "\nТоропитесь, предложение ограницено!\n");



        }
    }
}

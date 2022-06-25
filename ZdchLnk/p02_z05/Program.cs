using System;

namespace p02_z05
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, width, area;
            string temp;
            Console.WriteLine("Задача 1976");
            Console.WriteLine("Введите высоту прямоугольника");
            temp = Console.ReadLine();
            height = double.Parse(temp);
            Console.WriteLine("Введите ширину прямоугольника");
            temp = Console.ReadLine();
            width = double.Parse(temp);
            area = height * width;
            Console.WriteLine("Площадь прямоугольника со сторонами {0:F0} и {1:F0} равна {2:F0}", height, width, area);

        }
    }
}

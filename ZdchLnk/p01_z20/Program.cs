using System;

namespace p01_z20
{
    class Program
    {
        static void Main(string[] args)
        {
            String text;
            String text_2;
            String wot;
            String comma;
            String aeto;
            String kotoraya;
            String kotoryj;

            wot = "Вот ";
            aeto = "А это ";
            comma = ",\n";
            kotoraya = "Которая ";
            kotoryj = "Который ";

            text = "Дом, который постоил Джек.\n";
            Console.WriteLine("Самуил Маршак. " + text);
            text = "Вот дом,\nКоторый постоил Джек.\n";
            Console.WriteLine(text);
            text_2 = aeto + "пшеница" + comma;
            text = "Которая в тёмном чулане хранится\nВ доме,\nКоторый построил Джек.\n";
            Console.WriteLine(text_2 + text);
            text_2 = aeto + "весёлая птица-синица" + comma;
            text = kotoraya + "часто ворует пшеницу" + comma + text;
            Console.WriteLine(text_2 + text);
            text_2 = wot + "кот" + comma;
            text = kotoryj + "пугает и ловит синицу" + comma + text;
            Console.WriteLine(text_2 + text);
            text_2 = wot + "пёс без хвоста" + comma;
            text = kotoryj + "за шиворот треплет кота" + comma + text;
            Console.WriteLine(text_2 + text);
            text_2 = aeto + "коровая безрогая" + comma + "Лягнувшая старого пса без хвоста" + comma;
            Console.WriteLine(text_2 + text);
            text_2 = aeto + "старушка, седая и строгая" + comma;
            text = kotoraya + "доит корову безрогую" + comma + "Лягнувшую старого пса без хвоста" + comma + text;
            Console.WriteLine(text_2 + text);
            text_2 = aeto + "ленивый и толстый пастух" + comma;
            text = kotoryj + "бранится с коровницей строгою" + comma + text;
            Console.WriteLine(text_2 + text);
            text_2 = wot + "два петуха" + comma;
            text = "Которые будят того пастуха" + comma + text;
            Console.WriteLine(text_2 + text);

        }
    }
}

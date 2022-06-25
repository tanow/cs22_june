using System;

namespace p01_z13
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass, host, port, db;
            user = Console.ReadLine();
            pass = Console.ReadLine();
            host = Console.ReadLine();
            port = Console.ReadLine();
            db = Console.ReadLine();

            Console.WriteLine("User ID={0};Password={1};Host={2};Posr={3};Database={4}", user, pass, host, port, db);
            
        }
    }
}

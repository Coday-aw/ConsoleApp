using System;

namespace ConsoleApp123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("userName:");
            string userName = Console.ReadLine();

            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            Console.WriteLine($"welcome back, {userName}!");

        }
    }
}

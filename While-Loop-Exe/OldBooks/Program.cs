using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookNeeded = Console.ReadLine();
            string com = Console.ReadLine();
            int counter = 0;
            while (com != "No More Books")
            {
                if (bookNeeded == com)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                com = Console.ReadLine();
                counter++;
            }
            if (bookNeeded != com)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
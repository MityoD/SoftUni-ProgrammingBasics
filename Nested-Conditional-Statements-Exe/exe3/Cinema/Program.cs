using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price = 0;
            int totalSeats = rows * columns;
            switch (type)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }
            Console.WriteLine($"{totalSeats * price:F2} leva, income");

        }
    }
}


using System;

namespace examTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double priceForAdult = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            Console.WriteLine($"The profit of your agency from {name} tickets is {(adultTickets * priceForAdult + kidsTickets * (priceForAdult * 0.3) + (adultTickets + kidsTickets) * tax) * 0.2:F2} lv.");
        }
    }
}


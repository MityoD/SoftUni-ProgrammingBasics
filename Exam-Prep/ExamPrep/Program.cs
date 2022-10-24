using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double adultPrice = double.Parse(Console.ReadLine());
            double taxService = double.Parse(Console.ReadLine());
            double kidsPrice = adultPrice * 0.3;
            double totalPrice = adultTickets * (adultPrice + taxService) + kidsTickets * (kidsPrice + taxService);
            double income = totalPrice * 0.2;
            Console.WriteLine($"The profit of your agency from {name} tickets is {income:F2} lv.");
        }
    }
}

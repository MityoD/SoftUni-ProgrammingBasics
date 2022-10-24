using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int shipPrice = 1;
            double discount = 1;
            double bonusDiscount = 1;
            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
            }
            if (num <= 6)
            {
                discount = 0.9;
            }
            else if (num <= 11)
            {
                discount = 0.85;
            }
            else if (num > 12)
            {
                discount = 0.75;
            }
            if (season != "Autumn" && num % 2 == 0)
            {
                bonusDiscount = 0.95;
            }
            double totalPrice = (shipPrice * discount) * bonusDiscount;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva.");
            }
        }
    }
}

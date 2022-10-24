using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string valuation = Console.ReadLine();
            double price = 0;
            double discount = 1;
            int nights = days - 1;
            switch (roomType)
            {
                case "room for one person":
                    discount = 1;
                    price = 18.00;
                    break;
                case "apartment":
                    price = 25.00;
                    if (nights < 10)
                    {
                        discount = 0.7;
                    }
                    else if (nights <= 15)
                    {
                        discount = 0.65;
                    }
                    else if (nights > 15)                   
                    {
                        discount = 0.50;
                    }
                    break;
                case "president apartment":
                    price = 35.00;
                    if (nights < 10)
                    {
                        discount = 0.9;
                    }
                    else if (nights <= 15)
                    {
                        discount = 0.85;
                    }
                    else if (nights > 15)
                    {
                        discount = 0.8;
                    }
                    break;
            }
            double totalPrice = price * nights * discount;
            if (valuation == "positive")
            {
                totalPrice *= 1.25;
            }
            else if (valuation == "negative")
            {
                totalPrice *= 0.9;
            }
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}

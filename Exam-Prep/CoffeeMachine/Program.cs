using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            double discountWithoutSugar = 1;
            double discountEspresso5min = 1;
            double discountTotalMoreThan15 = 1;
            switch (drink)
            {
                case "Espresso":
                    switch (sugar)
                    {
                        case "Without":
                            price = 0.9;
                            break;
                        case "Normal":
                            price = 1;
                            break;
                        case "Extra":
                            price = 1.2;
                            break;
                    }
                    break;
                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            price = 1;
                            break;
                        case "Normal":
                            price = 1.2;
                            break;
                        case "Extra":
                            price = 1.6;
                            break;
                    }
                    break;
                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            price = 0.5;
                            break;
                        case "Normal":
                            price = 0.6;
                            break;
                        case "Extra":
                            price = 0.7;
                            break;
                    }
                    break;
            }
            if (sugar == "Without")
            {
                discountWithoutSugar = 0.65;
            }
            if (drink == "Espresso" && amount >= 5)
            {
                discountEspresso5min = 0.75;
            }
            totalPrice = ((amount * price) * discountWithoutSugar) * discountEspresso5min;
            if (totalPrice > 15)
            {
                totalPrice *= 0.8;
            }
            Console.WriteLine($"You bought {amount} cups of {drink} for {totalPrice:F2} lv.");
        }
    }
}

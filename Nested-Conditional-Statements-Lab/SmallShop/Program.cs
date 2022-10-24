using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal price = 0;

            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.5M;
                            break;
                        case "water":
                            price = 0.8M;
                            break;
                        case "beer":
                            price = 1.2M;
                            break;
                        case "sweets":
                            price = 1.45M;
                            break;
                        case "peanuts":
                            price = 1.6M;
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.4M;
                            break;
                        case "water":
                            price = 0.7M;
                            break;
                        case "beer":
                            price = 1.15M;
                            break;
                        case "sweets":
                            price = 1.30M;
                            break;
                        case "peanuts":
                            price = 1.50M;
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.45M;
                            break;
                        case "water":
                            price = 0.7M;
                            break;
                        case "beer":
                            price = 1.1M;
                            break;
                        case "sweets":
                            price = 1.35M;
                            break;
                        case "peanuts":
                            price = 1.55M;
                            break;
                    }
                    break;

            }
            Console.WriteLine(amount * price);

        }
    }
}

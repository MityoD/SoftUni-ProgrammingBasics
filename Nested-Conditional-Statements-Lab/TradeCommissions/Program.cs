using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double marketValue = double.Parse(Console.ReadLine());
            double commision = 0;
            switch (city)
            {
                case "Sofia":
                    if (marketValue >= 0 && marketValue <=500)
                    {
                        commision = 0.05;
                    }
                    else if (marketValue > 500 && marketValue <=1000)
                    {
                        commision = 0.07;
                    }
                    else if (marketValue > 1000 && marketValue <=10000)
                    {
                        commision = 0.08;
                    }
                    else if (marketValue > 10000)
                    {
                        commision = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (marketValue >= 0 && marketValue <= 500)
                    {
                        commision = 0.045;
                    }
                    else if (marketValue > 500 && marketValue <= 1000)
                    {
                        commision = 0.075;
                    }
                    else if (marketValue > 1000 && marketValue <= 10000)
                    {
                        commision = 0.10;
                    }
                    else if (marketValue > 10000)
                    {
                        commision = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (marketValue >= 0 && marketValue <= 500)
                    {
                        commision = 0.055;
                    }
                    else if (marketValue > 500 && marketValue <= 1000)
                    {
                        commision = 0.08;
                    }
                    else if (marketValue >1000 && marketValue <= 10000)
                    {
                        commision = 0.12;
                    }
                    else if (marketValue > 10000)
                    {
                        commision = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (commision != 0)
            {
                Console.WriteLine($"{marketValue * commision:F2}");
            }
        }
    }
}

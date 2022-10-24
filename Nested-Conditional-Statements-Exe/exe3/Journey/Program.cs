using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string type = "";
            double moneySpend = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    moneySpend = budget * 0.3;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpend = budget * 0.7;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneySpend = budget * 0.4;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpend = budget * 0.8;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                type = "Hotel";
                moneySpend = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {moneySpend:F2}");
        }
    }
}

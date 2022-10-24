using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyNeeded = decimal.Parse(Console.ReadLine());
            decimal moneyAvailable = decimal.Parse(Console.ReadLine());
            int daysSpendCounter = 0;
            int totalDays = 0;
            while (true)
            {
                totalDays++;
                string action = Console.ReadLine();
                decimal moneyToAction = decimal.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    daysSpendCounter++;
                    moneyAvailable -= moneyToAction;
                    if (moneyAvailable < 0)
                    {
                        moneyAvailable = 0;
                    }
                    if (daysSpendCounter > 4)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(totalDays);
                        break;
                    }
                }
                if (action == "save")
                {
                    daysSpendCounter = 0;
                    moneyAvailable += moneyToAction;
                    if (moneyAvailable >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {totalDays} days.");
                        break;
                    }
                }

            }
        }
    }
}

using System;

namespace CInemaBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string name = "";
            double money = 0;
            while ((name = Console.ReadLine()) != "ACTION")
            {
                if (name.Length <= 15)
                {
                money = double.Parse(Console.ReadLine());

                }
                else
                {
                money = budget * 0.2; 
                }
                budget -= money;
                if (budget <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):F2} leva for our actors.");
                    break;
                }
            }
            if (budget > 0)
            {
                Console.WriteLine($"We are left with {budget:F2} leva.");
            }
        }
    }
}

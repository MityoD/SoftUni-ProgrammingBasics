using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            int toysNum = 0;
            double moneyPresent = 0;

            double totalSum = 0;
            int brotherTook = 0;
            double moneyPresentTotal = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {                    
                    moneyPresent = moneyPresent + 10;
                    moneyPresentTotal = moneyPresentTotal + moneyPresent;
                    brotherTook++;
                }
                else
                {
                    toysNum++;
                }
            }
            totalSum = moneyPresentTotal + toysNum * priceToys - brotherTook;
            if (totalSum >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {totalSum - priceWashingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine - totalSum:F2}");
            }
            Console.WriteLine(moneyPresentTotal);
        }
    }
}

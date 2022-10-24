using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int amountFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            const double RosesPrice = 5.00;
            const double DahilasPrice = 3.8;
            const double TulipsPrice = 2.8;
            const double NarcissusPrice = 3;
            const double GladiolusPrice = 2.5;
            double discount = 1;
            double price = 0;
            if (flowerType == "Roses")
            {
                price = RosesPrice;
                if (amountFlowers > 80)
                {
                    discount = 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = DahilasPrice;
                if (amountFlowers > 90)
                {
                    discount = 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = TulipsPrice;
                if (amountFlowers > 80)
                {
                    discount = 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = NarcissusPrice;
                if (amountFlowers < 120)
                {
                    discount = 1.15;
                }
            }
            else if (flowerType =="Gladiolus")
            {
                price = GladiolusPrice;
                if (amountFlowers < 80)
                {
                    discount = 1.2;
                }
            }
            double totalPrice = price * amountFlowers * discount;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {amountFlowers} {flowerType} and {budget-totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice-budget:F2} leva more.");
            }
        }   
    }
}

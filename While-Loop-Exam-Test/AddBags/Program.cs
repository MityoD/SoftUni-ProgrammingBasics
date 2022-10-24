using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double bagPriceOver20 = double.Parse(Console.ReadLine());
            double bagKg = double.Parse(Console.ReadLine());
            int daysToFlight = int.Parse(Console.ReadLine());
            int bagsAmount = int.Parse(Console.ReadLine());
            double newPrice = 0;
            if (bagKg < 10)
            {
                newPrice = bagPriceOver20 * 0.2;
            }
            else if (bagKg>= 10 && bagKg <= 20)
            {
                newPrice = bagPriceOver20 * 0.5;
            }
            else
            {
                newPrice = bagPriceOver20;
            }
            if (daysToFlight > 30)
            {
                newPrice = newPrice * 1.1;
            }
            else if (daysToFlight >= 7)
            {
                newPrice = newPrice * 1.15;

            }
            else
            {
                newPrice = newPrice * 1.4;

            }
            Console.WriteLine($"The total price of bags is: {newPrice * bagsAmount:F2} lv. ");
        }
    }
}

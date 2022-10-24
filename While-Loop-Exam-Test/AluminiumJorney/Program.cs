using System;

namespace AluminiumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineryCount = int.Parse(Console.ReadLine());
            string joineryType = Console.ReadLine();
            string delivery = Console.ReadLine();
            double joineryPrice = 0;
            double totalPrice = 0;
            double discount = 1;
            const double deliveryPrice = 60;
            double extraDiscount = 1;
            if (joineryCount < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            if (joineryCount > 99)
            {
                extraDiscount = 0.96;
            }
            switch (joineryType)
            {
                case "90X130":
                    joineryPrice = 110;
                    if (joineryCount > 60)
                    {
                        discount = 0.92;
                    }
                    else if (joineryCount > 30)
                    {
                        discount = 0.95;
                    }
                    break;
                case "100X150":
                    joineryPrice = 140;
                    if (joineryCount > 80)
                    {
                        discount = 0.9;
                    }
                    else if (joineryCount > 40)
                    {
                        discount = 0.94;
                    }
                    break;
                case "130X180":
                    joineryPrice = 190;
                    if (joineryCount > 50)
                    {
                        discount = 0.88;
                    }
                    else if (joineryCount > 20)
                    {
                        discount = 0.93;
                    } 
                    break;
                case "200X300":
                    joineryPrice = 250;
                    if (joineryCount > 50)
                    {
                        discount = 0.86;
                    }
                    else if (joineryCount > 25)
                    {
                        discount = 0.91;
                    } 
                    break;
            }
            if (delivery == "With delivery")
            {
                totalPrice = (joineryCount * joineryPrice * discount + deliveryPrice) * extraDiscount;
                Console.WriteLine($"{totalPrice:F2} BGN");
            }
            else
            {
                totalPrice = joineryCount * joineryPrice * discount * extraDiscount;
                Console.WriteLine($"{totalPrice:F2} BGN");
            }

        }
    }
}


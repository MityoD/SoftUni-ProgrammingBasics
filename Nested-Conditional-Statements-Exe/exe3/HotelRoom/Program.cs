using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            double studioDiscount = 1;
            double apartmentDiscount = 1;
            if (days > 14)
            {
                apartmentDiscount = 0.9;
            }
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (days > 7 && days <= 14)
                    {
                        studioDiscount = 0.95;
                    }
                    else if (days > 14)
                    {
                        studioDiscount = 0.7;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 75.2;
                    apartmentPrice = 68.7;
                    if (days > 14)
                    {
                        studioDiscount = 0.8;
                    }
                    break;

                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }            
            Console.WriteLine($"Apartment: {apartmentPrice * days * apartmentDiscount:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice * days * studioDiscount:F2} lv.");
        }
    }
}

using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newMinutes = minutes + 15;
            if (newMinutes > 59)
            {
                hours++;
                newMinutes = newMinutes % 60;                
            }           
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{newMinutes:00}");
        }
    }
}

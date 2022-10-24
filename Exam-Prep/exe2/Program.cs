using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {

            int minutesWalk = int.Parse(Console.ReadLine());
            int dailyWalks = int.Parse(Console.ReadLine());
            int dailyCal = int.Parse(Console.ReadLine());
            int totalMinutes = minutesWalk * dailyWalks;
            int totalCaloriesBurned = totalMinutes * 5;
            if (totalCaloriesBurned >= (dailyCal/2))
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurned}.");
            }
        }
    }
}

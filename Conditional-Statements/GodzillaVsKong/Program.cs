using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double timesDelayed = Math.Floor(distanceMeters / 15);
            double delayedTime = timesDelayed * 12.5;
            double totalTime = delayedTime + secondsForOneMeter * distanceMeters;
            if (totalTime >= worldRecord)
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
        }        
    }
}

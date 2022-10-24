using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); 
            int h = int.Parse(Console.ReadLine());
            const int Weekends = 48;
            int weekendsInSofia = Weekends - h;
            double weekendsPlayedInSofia = weekendsInSofia * 0.75;
            double pPlayed = p * 2 / 3.0;
            double totalGames = h + weekendsPlayedInSofia + pPlayed;
            if (yearType == "leap")
            {
                double games = Math.Floor(totalGames * 1.15);
                Console.WriteLine(games);
            }
            else
            {
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}

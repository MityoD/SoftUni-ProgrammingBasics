using System;

namespace BasketballTournaments
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            double win = 0;
            double lose = 0;
            while ((name = Console.ReadLine()) != "End of tournaments")
            {
                int numGames = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numGames; i++)
                {
                    int desiPoints = int.Parse(Console.ReadLine());
                    int otherPoints = int.Parse(Console.ReadLine());
                    if (desiPoints > otherPoints)
                    {
                        win++;
                        Console.WriteLine($"Game {i} of tournament {name}: win with {desiPoints-otherPoints} points.");
                    }
                    else
                    {
                        lose++;
                        Console.WriteLine($"Game {i} of tournament {name}: lost with {otherPoints - desiPoints} points.");
                    }
                }
            }
            double totalgames = win + lose;
            Console.WriteLine($"{(win/totalgames)*100:F2}% matches win");
            Console.WriteLine($"{(lose/totalgames)*100:F2}% matches lost");
        }
    }
}

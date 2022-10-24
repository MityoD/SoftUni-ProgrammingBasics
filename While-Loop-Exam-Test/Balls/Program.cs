using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int redBallCounter = 0;
            int orangeBallCounter = 0;
            int yellowBallCounter = 0;
            int whiteBallCounter = 0;
            int blackBallCounter = 0;
            int otherBallColorCounter = 0;
            for (int i = 0; i < num; i++)
            {
                string ballColor = Console.ReadLine();
                switch (ballColor)
                {
                    case "red":
                        redBallCounter++;
                        totalPoints += 5;
                        break;
                    case "orange":
                        orangeBallCounter++;
                        totalPoints += 10;
                        break;
                    case "yellow":
                        yellowBallCounter++;
                        totalPoints += 15;
                        break;
                    case "white":
                        whiteBallCounter++;
                        totalPoints += 20;
                        break;
                    case "black":
                        blackBallCounter++;
                        totalPoints /= 2;
                        break;
                    default:
                        otherBallColorCounter++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {redBallCounter}");
            Console.WriteLine($"Points from orange balls: {orangeBallCounter}");
            Console.WriteLine($"Points from yellow balls: {yellowBallCounter}");
            Console.WriteLine($"Points from white balls: {whiteBallCounter}");
            Console.WriteLine($"Other colors picked: {otherBallColorCounter}");
            Console.WriteLine($"Divides from black balls: {blackBallCounter}");

        }
    }
}

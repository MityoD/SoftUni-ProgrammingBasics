using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int cakeLeft = width * lenght;
            string takeCake = Console.ReadLine();
            while (takeCake != "STOP")
            {
                int takePiece = int.Parse(takeCake);
                cakeLeft -= takePiece;
                if (cakeLeft < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeLeft)} pieces more.");
                    break;
                }
                takeCake = Console.ReadLine();
            }
            if (cakeLeft > 0)
            {
                Console.WriteLine($"{cakeLeft} pieces are left.");
            }
        }
    }
}

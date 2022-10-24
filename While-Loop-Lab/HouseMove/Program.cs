using System;

namespace HouseMove
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int volume = width * lenght * height;            
            while (input != "Done")
            { 
                int boxes = int.Parse(input);
                volume -= boxes;
                if (volume < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (volume > 0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
        }
    }
}

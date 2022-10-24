using System;

namespace BestPlayerWhileTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int maxGoals = 0;
            string topPlayer = "";
            while ((name = Console.ReadLine()) != "END")
            {              
                int goalScored = int.Parse(Console.ReadLine());
                if (goalScored > maxGoals)
                {
                    topPlayer = name;
                    maxGoals = goalScored;
                }
                if (goalScored >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{topPlayer} is the best player!");
            if (maxGoals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}

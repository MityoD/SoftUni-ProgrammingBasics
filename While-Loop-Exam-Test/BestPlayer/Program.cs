using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int goalScored = int.Parse(Console.ReadLine());
            int maxGoals = 0;
            string topPlayer = "";
            while (goalScored < 10)
            {
                if (goalScored > maxGoals)
                {
                    topPlayer = name;
                    maxGoals = goalScored;
                }
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                goalScored = int.Parse(Console.ReadLine());
                
                
            }

            if (goalScored >= 10)
            {
                Console.WriteLine($"{name} is the best player!");
                Console.WriteLine($"He has scored {goalScored} goals and made a hat-trick !!!");
            }
            else if (goalScored >= 3)
            {
                Console.WriteLine($"{topPlayer} is the best player!");
                Console.WriteLine($"He has scored {goalScored} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{topPlayer} is the best player!");
                Console.WriteLine($"He has scored {goalScored} goals.");
            }
        }
    }
}

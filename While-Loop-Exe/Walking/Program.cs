using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Goal = 10000;
            int totalSteps = 0;
            while (totalSteps < Goal)
            {
                string steps = Console.ReadLine();                
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    int stepsExtra = int.Parse(steps);
                    totalSteps += stepsExtra;
                    break;
                }
                int stepsToInt = int.Parse(steps);
                totalSteps += stepsToInt;
            }
            if (totalSteps >= Goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - Goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Goal - totalSteps} more steps to reach goal.");
            }
        }
    }
}

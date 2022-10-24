using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            int badMarksCounter = 0;
            int taskCounter = 0;
            double totalMarks = 0;
            string task = "";

            while (true)
            {
                string newTask = Console.ReadLine();
                if (newTask == "Enough")
                {
                    break;
                }
                int markForTask = int.Parse(Console.ReadLine());
                if (markForTask <= 4)
                {
                    badMarksCounter++;
                    if (badMarksCounter >= badMarks)
                    {
                        Console.WriteLine($"You need a break, {badMarksCounter} poor grades.");
                        break;
                    }
                }
                totalMarks += markForTask;
                taskCounter++;
                task = newTask;
            }            
            if (badMarksCounter < badMarks)
            {
                Console.WriteLine($"Average score: {totalMarks / taskCounter:F2}");
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {task}");
            }

        }
    }
}

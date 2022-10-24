using System;

namespace examPrepHELP
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            int badMarksCounter = 0;
            int taskCounter = 0;
            double totalMarks = 0;
            string lastTask = "";
            bool isFailed = true;
            while (badMarksCounter < badMarks)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badMarksCounter++;
                }
                totalMarks += grade;
                taskCounter++;
                lastTask = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badMarksCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {totalMarks / taskCounter:F2}");
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}

using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());
            int totalExamMinutes = hourExam * 60 + minutesExam;
            int totalArriveMinutes = hourArrive * 60 + minutesArrive;
            int minutesLeft = totalExamMinutes - totalArriveMinutes;            
            if (minutesLeft >= 0 && minutesLeft <= 30)
            {
                if (minutesLeft == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesLeft} minutes before the start");
                }
            }
            else if (minutesLeft < 0)
            {
                if (minutesLeft <= -60)
                {
                    int hoursLate = Math.Abs(minutesLeft) / 60;
                    int minutesLate = Math.Abs(minutesLeft) % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hoursLate}:{minutesLate:00} hours after the start");
                }
                else if (minutesLeft > -60)
                {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(minutesLeft)} minutes after the start");
                }

            }
            else if (minutesLeft > 30)
            {
                if (minutesLeft >= 60)
                {
                int hoursLeft = minutesLeft / 60;
                int minutesEarly = minutesLeft % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{hoursLeft}:{minutesEarly:00} hours before the start");
                }
                else
                {
                Console.WriteLine("Early");
                Console.WriteLine($"{minutesLeft} minutes before the start");

                }
            }            

        }
    }
}

using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());
            double socialScolarship = 0;
            double excellentScolarship = 0;

            if (income < minimumWage && grade >= 4.50)
            {
                socialScolarship = Math.Floor(minimumWage * 0.35);
               
            }
            if (grade >= 5.50)
            {
                excellentScolarship = Math.Floor(grade * 25);
                
            }
            if (socialScolarship == 0 && excellentScolarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScolarship > 0 && excellentScolarship > 0)
            {
                if (socialScolarship > excellentScolarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentScolarship} BGN");
                }
            }
            else if (socialScolarship > 0)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else if (excellentScolarship > 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScolarship} BGN");
            }
        }
    }
}

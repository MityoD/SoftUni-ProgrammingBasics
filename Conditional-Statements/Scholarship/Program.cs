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
            double socialScolarship = Math.Floor(minimumWage * 0.35);
            double excellentScolarship = Math.Floor(grade * 25);            
            
            if (income < minimumWage && grade >= 5.50)
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
            else if (income < minimumWage && grade > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else if (grade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScolarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}

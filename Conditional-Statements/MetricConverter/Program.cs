using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string unitIn = Console.ReadLine();
            string unitOut = Console.ReadLine();

            if (unitIn == "cm")
            {
                number = number * 10;
            }
            else if (unitIn == "m")
            {
                number = number * 1000;
            }
            if (unitOut == "cm")
            {
                number = number / 10;
            }
            else if (unitOut == "m")
            {
                number = number / 1000;
            }
            Console.WriteLine($"{number:F3}");
        }
    }
}

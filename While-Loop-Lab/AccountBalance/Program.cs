using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double total = 0;
            while (command != "NoMoreMoney")
            {   int toInt = int.Parse(command);
                if (toInt < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {total:f2}");
                    break;
                }
                Console.WriteLine($"Increase: {toInt:f2}");
                total += toInt;

            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}

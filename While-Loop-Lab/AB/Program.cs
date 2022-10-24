using System;

namespace AB
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
                double total = 0;
                while (command != "NoMoreMoney")
                {
                    double toDouble = double.Parse(command);
                    if (toDouble < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        Console.WriteLine($"Total: {total:f2}");
                    return;
                    }
                    Console.WriteLine($"Increase: {toDouble:f2}");
                    total += toDouble;
                command = Console.ReadLine();

                }
                Console.WriteLine($"Total: {total:f2}");
            }
        }
    }


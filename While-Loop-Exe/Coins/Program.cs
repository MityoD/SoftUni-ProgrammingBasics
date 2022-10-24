using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            int counter = 0;

            while (sum > 0)
            {
                if (sum >= 2m)
                {
                    sum -= 2m;                    
                }
                else if (sum >= 1m)
                {
                    sum -= 1m;
                }
                else if (sum >= 0.5m)
                {
                    sum -= 0.5m;
                }
                else if (sum >= 0.2m)
                {
                    sum -= 0.2m;
                }
                else if (sum >= 0.1m)
                {
                    sum -= 0.1m;
                }
                else if (sum >= 0.05m)
                {
                    sum -= 0.05m;
                }
                else if (sum >= 0.02m)
                {
                    sum -= 0.02m;
                }
                else if (sum >= 0.01m)
                {
                    sum -= 0.01m;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
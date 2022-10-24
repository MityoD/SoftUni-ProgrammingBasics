using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i <= n - 1; i += 2)
            {
                int sumOdd = int.Parse(Console.ReadLine());
                sum1 += sumOdd;
                for (int i1 = 1; i1 < n - 1; i1 += 2)
                {
                    int sumEven = int.Parse(Console.ReadLine());
                    sum2 += sumEven;
                }

            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}

using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int i = 0; i < n; i++)
            {                
                int sum = int.Parse(Console.ReadLine());
                sum1 += sum;
                
            }
            Console.WriteLine(sum1);
        }
    }
}

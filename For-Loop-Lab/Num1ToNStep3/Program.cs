using System;

namespace Num1ToNStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

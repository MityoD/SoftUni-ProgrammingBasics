using System;

namespace PowerEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= N; i+=2)
            {
                Console.WriteLine(num);
                num = num * 2 * 2;                
            }
        }
    }
}

using System;

namespace MinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int minNum = int.MaxValue;
            while (num != "Stop")
            {
                int numToInt = int.Parse(num);
                if (numToInt < minNum)
                {
                    minNum = numToInt;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}

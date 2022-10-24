using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int maxNum = int.MinValue;
            while (num != "Stop")
            {
                int numToInt = int.Parse(num);
                if (numToInt > maxNum)
                {
                    maxNum = numToInt;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}

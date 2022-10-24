using System;

namespace TreckingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = 0;
            int musalaGroup = 0;
            int monblanGroup = 0;
            int kilimanjaroGroup = 0;
            int k2Group = 0;
            int everestGroup = 0;
            int groups = int.Parse(Console.ReadLine());
            for (int i = 1; i <= groups; i++)
            {
                int num = int.Parse(Console.ReadLine());
                totalPeople += num;
                if (num <= 5)
                {
                    musalaGroup += num;
                }
                else if (num <= 12)
                {
                    monblanGroup += num;
                }
                else if (num <= 25)
                {
                    kilimanjaroGroup += num;
                }
                else if (num <= 40)
                {
                    k2Group += num;
                }
                else
                {
                    everestGroup += num;
                }
            }
            Console.WriteLine($"{((double)musalaGroup / totalPeople) * 100:F2}%");
            Console.WriteLine($"{((double)monblanGroup / totalPeople) * 100:F2}%");
            Console.WriteLine($"{((double)kilimanjaroGroup / totalPeople) * 100:F2}%");
            Console.WriteLine($"{((double)k2Group / totalPeople) * 100:F2}%");
            Console.WriteLine($"{((double)everestGroup / totalPeople) * 100:F2}%");
        }
    }
}

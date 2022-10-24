using System;

namespace Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int ind3num1 = num1 % 10;
            int ind2num1 = (num1 / 10) % 10;
            int ind1num1 = (num1 / 100) % 10;
            int ind0num1 = (num1 / 1000) % 10;
            int ind3num2 = num2 % 10;
            int ind2num2 = (num2 / 10) % 10;
            int ind1num2 = (num2 / 100) % 10;
            int ind0num2 = (num2 / 1000) % 10;

            for (int i0 = ind0num1; i0 <= ind0num2; i0++)
            {
                for (int i1 = ind1num1; i1 <= ind1num2; i1++)
                {
                    for (int i2 = ind2num1; i2 <= ind2num2; i2++)
                    {
                        {
                            for (int i3 = ind3num1; i3 <= ind3num2; i3++)
                            {
                                if (i0 % 2 != 0 && i1 % 2 != 0 && i2 % 2 != 0 && i3 % 2 != 0)
                                    Console.Write($"{i0}{i1}{i2}{i3} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

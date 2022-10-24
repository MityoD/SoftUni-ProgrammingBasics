using System;

namespace IndexTryFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string num1ToSting = Convert.ToString(num1);
            string num2ToSting = Convert.ToString(num2);
            int num1Index0 = (int)Char.GetNumericValue(num1ToSting[0]);
            int num1Index1 = (int)Char.GetNumericValue(num1ToSting[1]);
            int num1Index2 = (int)Char.GetNumericValue(num1ToSting[2]);
            int num1Index3 = (int)Char.GetNumericValue(num1ToSting[3]);
            int num2Index0 = (int)Char.GetNumericValue(num2ToSting[0]);
            int num2Index1 = (int)Char.GetNumericValue(num2ToSting[1]);
            int num2Index2 = (int)Char.GetNumericValue(num2ToSting[2]);
            int num2Index3 = (int)Char.GetNumericValue(num2ToSting[3]);
            for (int i0 = num1Index0; i0 <= num2Index0; i0++)
            {
                for (int i1 = num1Index1; i1 <= num2Index1; i1++)
                {
                    for (int i2 = num1Index2; i2 <= num2Index2; i2++)
                    {
                        for (int i3 = num1Index3; i3 <= num2Index3; i3++)
                        {
                            if (i0 % 2 != 0 && i1 % 2 != 0 && i2 % 2 != 0 && i3 % 2 != 0)
                            {
                                Console.Write($"{i0}{i1}{i2}{i3} ");
                            }
                        }  
                    }
                }
            }           
        }
    }
}

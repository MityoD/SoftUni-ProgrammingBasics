using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;
            string evenOrOdd = "";
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }
                    else
                    {
                        
                        result = (num1 + 0.0) / num2;
                        Console.WriteLine($"{num1} {op} {num2} = {result:F2}");
                        return;
                    }                                        
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }
                    result = num1 % num2;
                    break;
            }
            if (op == "+" || op == "-" || op == "*")
            {
                if (result % 2 == 0)
                {
                    evenOrOdd = "- even";
                }
                else
                {
                    evenOrOdd = "- odd";
                }
            }
            Console.WriteLine($"{num1} {op} {num2} = {result} {evenOrOdd}");
        }
    }
}

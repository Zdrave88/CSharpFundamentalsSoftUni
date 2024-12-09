
using System;
using System.Diagnostics;

namespace demo
{
    internal class Program
    {
        static void Main()
        {
            int numA = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateResult(numA, operation, numB));
        }

        static double CalculateResult(int numA, char operation, int numB)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = numA + numB; break;
                case '-':
                    result = numA - numB; break;
                case '*':
                    result = numA * numB; break;
                case '/':
                    result = numA / numB; break;
            }
            return result;
        }
    }
}
